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
using Slipe.Json;
using Slipe.Exports;

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

        private Database database;

        public Program()
        {
            database = new Database(new MySqlConnectionString()
            {
                Hostname = "127.0.0.1",
                Port = 3306,
                DbName = "test"
            }, "user", "password");

            Vehicle alpha = new Vehicle(VehicleModel.Alpha, new Vector3(0, 10, 3));

            alpha.OnDamage += HandleDamage;
        }

        public async void HandleDamage(float loss)
        {
            database.Exec("INSERT INTO `alpha_log` (`loss`) VALUES (?)", loss);
            var result = await database.Query("SELECT COUNT(`loss`) as count FROM `alpha_log`");
            ChatBox.WriteLine(string.Format("The alpha has been damaged {0} times", (int)result[0]["count"]), 0xff00ff);
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
