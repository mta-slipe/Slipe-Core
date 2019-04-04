using Slipe.Server;
using Slipe.Shared;
using Slipe.Shared.Enums;
using Slipe.Shared.Exceptions;
using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using RPCDefinitions;
using System.Timers;
using Slipe.Shared.RPC;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using System.Net.Sockets;
using System.Net;
using System.Text;
using Slipe.Server.IO;
using Slipe.Server.Vehicles;
using Slipe.Shared.Vehicles;

namespace ServerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            new ElementManager(new ElementHelper());
            Timer aTimer = new Timer(2000);
            Console.WriteLine(aTimer.AutoReset.ToString());
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Enabled = true;
            aTimer.Interval = 4000;
            new Program();
        }

        public static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The elapsed event was raised at " + e.SignalTime.ToString());
            Timer t = (Timer)source;
            t.Enabled = false;
        }

        public Program()
        {
            Debug.WriteLine(Server.Name);
            List<TurretedVehicle> vehicles = new List<TurretedVehicle>(); ;
            for (int i = 0; i < 10; i++)
            {
                TurretedVehicle rhino = new TurretedVehicle(TurretedModel.Rhino, new Vector3(i * 15, 0, 3));
                Blip blip = new Blip(rhino);
                vehicles.Add(rhino);
            }
            vehicles[5].Rotation = new Vector3(0, 0, 45);

            WorldObject dildo = new WorldObject(321, new Vector3(3, 3, 3));
            dildo.Scale = new Vector3(3, 3, 3);
            dildo.Move(5000, new Vector3(3, 3, 10), Vector3.Zero, EasingFunctionEnum.COSINECURVE, 0.4f, 0.5f);
            Console.WriteLine("{0} is a pleb", "SAES>Dezzolation");

            vehicles[4].AttachTo(dildo, new Vector3(0, 0, 3), Vector3.Zero);

            Dictionary<string, TurretedVehicle> vehicleDictionary = new Dictionary<string, TurretedVehicle>();
            vehicleDictionary["best"] = vehicles[3];
            vehicleDictionary["best"].Position = new Vector3(0, 0, 20);
            vehicleDictionary["best"].Frozen = true;

            foreach (Vehicle vehicle in ElementHelper.GetByType<Vehicle>())
            {
                vehicle.Rotation = new Vector3(0, 0, 90);
            }

            Element.Root.AddEventHandler("onVehicleDamage");

            Color color = new Color(0x0000ff);
            color = new Color(0xff00ffaa);
            color = new Color((uint) 0x000000ff);
            Debug.WriteLine("Color: {0}, {1}, {2}, {3}", color.R, color.G, color.B, color.A);

            Vehicle alpha = new Vehicle(VehicleModel.Alpha, new Vector3(0, 10, 3));

            // BROKEN UNTIL FIXED BY YUAN
            //alpha.Sirens.Add(new Vector3(0, 0, 1), Color.Red, 100);
            //alpha.Sirens.Type = SirenType.dual;
            //alpha.Sirens.On = true;

            // alpha.AddEventHandler("onVehicleDamage");
            alpha.OnDamage += (float loss) =>
            {
                Dictionary<Seat, Player> occupants = alpha.Occupants;
                Debug.WriteLine(occupants.Count);
                foreach(KeyValuePair<Seat, Player> oc in occupants)
                {
                    Debug.WriteLine(oc.Value.Name);
                }
                Debug.WriteLine("Vehicle lost " + loss +" health");
                try
                {
                    Player nano = (Player)Player.GetFromName("SAES>Nanobob");
                    RPCManager.Instance.TriggerRPC(nano, "testRPC", new BasicOutgoingRPC("Vehicle damage", (int)loss, nano));
                }
                catch (NullElementException) { }

            };

            Player[] alives = Player.Alive;
            foreach(Player p in alives)
            {
                Console.WriteLine(p.Name);
            }

            Debug.WriteLine(alpha.Handling.Mass);
            alpha.Handling.Mass = alpha.Handling.Mass * 1.5f;
            Debug.WriteLine(alpha.Handling.Mass);

            try
            {
                Player player = (Player) Player.GetFromName("SAES>DezZolation");
                Pickup pickup = new Pickup(player.Position + player.ForwardVector * 3, WeaponEnum.COLT45, 200);
                pickup.Use(player);
                Console.WriteLine(pickup.RespawnInterval.ToString());
            }
            catch(NullElementException)
            {
                Console.WriteLine("ha");
            }

            Blip blip2 = new Blip(new Vector3(0, 0, 0), BlipEnum.BURGERSHOT, Color.Red, 2);
            Vector3 vect = blip2.ForwardVector;
            Console.WriteLine(vect.ToString());

            RadarArea area = new RadarArea(new Vector2(200, 200), new Vector2(400, 400), new Color(40, 120, 255));
            Debug.WriteLine(area.Type);
            area.Flashing = true;

            foreach(Account account in Account.All)
            {
                account.SetData("Test", "Success");
                foreach(KeyValuePair<string, string> pair in account.AllData)
                {
                    Debug.WriteLine(pair.Key);
                    Debug.WriteLine(pair.Value);
                }
            }

            RPCManager.Instance.RegisterRPC<EmptyIncomingRPC>("onPlayerReady", (Player player, EmptyIncomingRPC rpc) =>
            {
                Console.WriteLine("{0} has sent the ready event", player.Name);
            });
            Console.WriteLine(Resource.This.LoadTime.ToString());

            // Console.WriteLine(File.ReadAllText("meta.xml"));
            // Task.Run(TestMethod);
            // Console.WriteLine("10");
            // HttpTest();

            //XmlDocument document = new XmlDocument();
            //document.Load("test.xml");

            //foreach(XmlElement item in document.FirstChild.FirstChild.ChildNodes)
            //{
            //    Console.WriteLine(item.Value);
            //}
            //XmlElement newElement = document.CreateElement("new");
            //newElement.Value = "test";
            //document.FirstChild.AppendChild(newElement);
            //document.Save("test.xml");

            Task _ = DoSocket();


            // JSON test
            //string json = MTAShared.ToJSON(new JsonTestStruct()
            //{
            //    x = 5,
            //    y = "Hello world",
            //    struc = new JsonTestStruct2()
            //    {
            //        z = 50,
            //        ints = new int[5]
            //        {
            //            1, 2, 3, 4, 5
            //        }
            //    }
            //}, true, "none");

            //JsonTestStruct unserializedJson = (JsonTestStruct)MTAShared.FromJSON(json);
            //Console.WriteLine(unserializedJson.struc.z);
            //foreach(int i in unserializedJson.struc.ints)
            //{
            //    Console.WriteLine(i);
            //}

            new CommandHandler("testCommand", (string command, string[] parameters) =>
            {
                foreach(string parameter in parameters)
                {
                    Console.WriteLine(parameter);
                }
            });
        }

        public async Task DoSocket()
        {
            Socket socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            await socket.ConnectAsync(IPAddress.Parse("52.20.16.20"), 30000);

            Console.WriteLine("We've connected");
            string message = "Test message";
            socket.Send(Encoding.ASCII.GetBytes(message));

            byte[] buffer = new byte[1024];
            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, Receive, new SocketState()
            {
                buffer = buffer,
                socket = socket
            });
        }

        public void Receive(IAsyncResult result)
        {
            SocketState state = (SocketState)result.AsyncState;
            Socket socket = state.socket;
            byte[] buffer = state.buffer;

            int bytesRead = socket.EndReceive(result);
            string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Console.WriteLine("We've received: {0}", message);

            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, Receive, result.AsyncState);
        }

        private async Task HttpTest()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://nanobob.net");
            HttpResponseMessage postResponse = await client.PostAsync("https://nanobob.net/sendData/", new FormUrlEncodedContent(
                new List<KeyValuePair<string, string>>() {
                    new KeyValuePair<string, string>("TestKey", "TestValue"),
                    new KeyValuePair<string, string>("TestKey2", "TestValue2"),
                })
            );
            Console.WriteLine("Post request status code: {0}, sucess: {1}", postResponse.StatusCode, postResponse.IsSuccessStatusCode);
        }

        private async Task TestMethod()
        {
            Console.WriteLine(await TestMethodTwo());
        }

        private async Task<int> TestMethodTwo()
        {
            await Task.Delay(1000);
            return 5;
        }
    }

    struct SocketState
    {
        public Socket socket;
        public byte[] buffer;
    }

    struct JsonTestStruct
    {
        public int x;
        public string y;
        public JsonTestStruct2 struc;
    }

    struct JsonTestStruct2
    {
        public int z;
        public int[] ints;
    }
}
