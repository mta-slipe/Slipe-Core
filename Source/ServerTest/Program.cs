using Slipe.Shared.Exceptions;
using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using RPCDefinitions;
using System.Timers;
using Slipe.Shared.Rpc;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using System.Net.Sockets;
using System.Net;
using System.Text;
using Slipe.Server.IO;
using Slipe.Server.Vehicles;
using Slipe.Shared.Vehicles;
using Slipe.Shared.Elements;
using Slipe.Shared.Weapons;
using Slipe.Shared.Utilities;
using Slipe.Shared.Radar;
using Slipe.Server.Accounts;
using Slipe.Server.Radar;
using Slipe.Server.Elements;
using Slipe.Server.GameWorld;
using Slipe.Server.GameServer;
using Slipe.Shared.Helpers;
using Slipe.Server.Pickups;
using Slipe.Server.Resources;
using Slipe.Server.Rpc;
using Slipe.Server.Peds;
using Slipe.Shared.Peds;
using Slipe.Server.Weapons;
using Slipe.Sql;
using Slipe.Server.Displays;
using Slipe.Shared.IO;
using Slipe.Shared.Cryptography;

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
            List<Vehicle> vehicles = new List<Vehicle>(); ;
            for (int i = 0; i < 10; i++)
            {
                Vehicle rhino = new TurretedVehicle(TurretedModel.Rhino, new Vector3(i * 15, 0, 3));
                Blip blip = new Blip(rhino);
                vehicles.Add(rhino);
            }
            vehicles[5].Rotation = new Vector3(0, 0, 45);

            WorldObject dildo = new WorldObject(321, new Vector3(3, 3, 3));
            dildo.Scale = new Vector3(3, 3, 3);
            dildo.Move(5000, new Vector3(3, 3, 10), Vector3.Zero, EasingFunction.CosineCurve, 0.4f, 0.5f);
            Console.WriteLine("{0} is a pleb", "SAES>Dezzolation");

            vehicles[4].AttachTo(dildo, new Vector3(0, 0, 3), Vector3.Zero);

            Dictionary<string, Vehicle> vehicleDictionary = new Dictionary<string, Vehicle>();
            vehicleDictionary["best"] = vehicles[3];
            vehicleDictionary["best"].Position = new Vector3(0, 0, 20);
            vehicleDictionary["best"].Frozen = true;

            foreach (Vehicle vehicle in ElementHelper.GetByType<Vehicle>())
            {
                vehicle.Rotation = new Vector3(0, 0, 90);
            }

            Color color = new Color(0x0000ff);
            color = new Color(0xff00ffaa);
            color = new Color((uint) 0x000000ff);
            Debug.WriteLine("Color: {0}, {1}, {2}, {3}", color.R, color.G, color.B, color.A);

            Vehicle patriot = new Vehicle(VehicleModel.Patriot, new Vector3(0, 15, 3));

            patriot.Sirens.Add(new Vector3(-0.6f, 1, 0.5f), Color.Red, 200);
            patriot.Sirens.Add(new Vector3(0.6f, 1, 0.5f), new Color(0, 0, 255), 200);
            patriot.Sirens.On = true;
            patriot.Sirens.Silent = true;

            Vehicle alpha = new Vehicle(VehicleModel.Alpha, new Vector3(0, 10, 3));

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
                    RpcManager.Instance.TriggerRPC(nano, "testRPC", new BasicOutgoingRpc("Vehicle damage", (int)loss, nano));
                }
                catch (NullElementException) { }

            };

            SuperSwatTank swatTank = new SuperSwatTank(new Vector3(0, 25, 4));

            Player[] alives = Player.Alive;
            foreach(Player p in alives)
            {
                Console.WriteLine(p.Name);
            }

            Debug.WriteLine(alpha.Handling.Mass);
            alpha.Handling.Mass = alpha.Handling.Mass * 1.5f;
            Debug.WriteLine(alpha.Handling.Mass);

            Display d1 = new Display();
            Item t = new Item(d1, "You're a noob", new Vector2(0.5f, 0.5f));
            Display d2 = new Display();
            Item b = new Item(d2, "Bob is a noob", new Vector2(0.5f, 0.5f));

            try
            {
                Player bob = (Player)Player.GetFromName("SAES>Nanobob");
                d1.AddObserver(bob);
            }
            catch(NullElementException)
            { 
                d2.AddObservers(Player.Alive);
            }

            try
            {
                Player player = (Player) Player.GetFromName("SAES>DezZolation");
                player.OnConsole += (string command) =>
                {
                    Console.WriteLine(command);
                };
                player.OnConsole += (string command) =>
                {
                    Console.WriteLine(command + "HA");
                };
                player.OnClick += (MouseButton mouseButton, MouseButtonState buttonState, PhysicalElement clickedElement, Vector3 worldPosition, Vector2 screenPosition) =>
                {
                    if(mouseButton == MouseButton.Left && buttonState == MouseButtonState.Down)
                    {
                        if(clickedElement != null)
                        {
                            Console.WriteLine(clickedElement.GetZoneName());
                        }                        
                        Console.WriteLine(worldPosition.ToString());
                        Console.WriteLine(screenPosition.ToString());
                    }

                };
                player.PlaySoundFrontEnd(FrontEndSound.RadioStatic);
                Pickup pickup = new Pickup(player.Position + player.ForwardVector * 3, WeaponModel.Colt45, 200);
                pickup.OnUse += (Player p) =>
                {
                    Debug.WriteLine(p.IP);
                };
                pickup.OnSpawn += () =>
                {
                    Console.WriteLine("PICKUP RESPAWNED");
                };
                Console.WriteLine(pickup.RespawnInterval.ToString());
            }
            catch(NullElementException)
            {
                Console.WriteLine("ha");
            }

            Blip blip2 = new Blip(new Vector3(0, 0, 0), BlipType.Burgershot, Color.Red, 2);
            Vector3 vect = blip2.ForwardVector;
            Console.WriteLine(vect.ToString());

            RadarArea area = new RadarArea(new Vector2(200, 200), new Vector2(400, 400), new Color(40, 120, 255));
            Debug.WriteLine(area.Type);
            area.Flashing = true;
            foreach(Account account in Account.All)
            {
                account.SetData("Test", "Success");
                foreach(KeyValuePair<string, string> pair in account.Data)
                {
                    Debug.WriteLine(pair.Key);
                    Debug.WriteLine(pair.Value);
                }
            }

            RpcManager.Instance.RegisterRPC<EmptyIncomingRpc>("onPlayerReady", (Player player, EmptyIncomingRpc rpc) =>
            {
                Console.WriteLine("{0} has sent the ready event", player.Name);
            });
            Console.WriteLine(Resource.This.LoadTime.ToString());

            Task _ = DoCrypto();

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

            // Task _ = DoSocket();


            // JSON test
            //string json = MtaShared.ToJSON(new JsonTestStruct()
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

            //JsonTestStruct unserializedJson = (JsonTestStruct)MtaShared.FromJSON(json);
            //Console.WriteLine(unserializedJson.struc.z);
            //foreach (int i in unserializedJson.struc.ints)
            //{
            //    Console.WriteLine(i);
            //}

            new CommandHandler("testCommand", (string command, string[] parameters) =>
            {
                foreach(string parameter in parameters)
                {
                    Console.WriteLine(parameter);
                }
                Server.Log.WriteLine("I AM A SERVER LOG!");
                Server.Debug.WriteLine("I AM AN ERROR!", Slipe.Shared.IO.DebugMessageLevel.Error);
                ChatBox.WriteLine("I am a chat message!", 0xff00ff);
            });

            //_ = DoSql();
        }

        public async Task DoCrypto()
        {
            string cryptoTest = "If the Easter Bunny and the Tooth Fairy had babies would they take your teeth and leave chocolate for you?";
            string hash = Sha512.Hash(cryptoTest);
            Console.WriteLine(Sha512.Verify(cryptoTest, hash).ToString());

            hash = await Bcrypt.Hash(cryptoTest);
            Console.WriteLine(hash);
            bool verified = await Bcrypt.Verify(cryptoTest, hash);
            Console.WriteLine(verified.ToString());
        }

        public async Task DoSql()
        {
            Database database = new Database(new MySqlConnectionString()
            {
                Hostname = "127.0.0.1",
                Port = 3306,
                DbName = "test"
            }, "user", "password");

            Random random = new Random();
            database.Exec("INSERT INTO `vector` (`x`, `y`, `z`) VALUES(?, ?, ?)", new object[]{
                random.Next(0, 1000),
                random.Next(0, 1000),
                random.Next(0, 1000)
            });

            var results = await database.Query("SELECT * FROM `vector`");
            foreach(var row in results)
            {
                Console.WriteLine("X: {0}, Y: {1}, Z: {2}", (int) row["x"], (int) row["y"], (int) row["z"]);
                int xResult = row["x"] + 10;
            }
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

    public class SuperSwatTank : TurretedVehicle
    {
        public SuperSwatTank(Vector3 pos) : base(TurretedModel.Swat, pos)
        {
            this.OnDamage += PrintFoo;
        }

        public void PrintFoo(float loss)
        {
            Debug.WriteLine(Foo() + " " + loss.ToString());
        }

        public string Foo()
        {
            return "foo";
        }
    }
}
