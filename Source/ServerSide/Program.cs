using SlipeLua.MtaDefinitions;
using SlipeLua.Server.Game;
using SlipeLua.Server.IO;
using SlipeLua.Server.Peds;
using SlipeLua.Server.Peds.Events;
using SlipeLua.Server.Resources;
using SlipeLua.Server.Rpc;
using SlipeLua.Server.Vehicles;
using SlipeLua.Server.Vehicles.Events;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Exports;
using SlipeLua.Shared.Peds;
using SlipeLua.Shared.Rendering;
using SlipeLua.Shared.Rpc;
using SlipeLua.Shared.Utilities;
using System;
using System.Numerics;
using System.Threading.Tasks;
using System.Xml;

namespace ServerSide
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            //new KillMessagesResource().Start();

            // Spawn a player in Blueberry
            Player.OnJoin += (Player source, OnJoinEventArgs eventArgs) =>
            {
                source.Spawn(new Vector3(0, 0, 5), PedModel.ballas1);

                source.OnLogin += OnPlayerLogin;

                RpcManager.Instance.TriggerRPC(source, "queue", new EmptyRpc() { OnClientRpcFailed = ClientRpcFailedAction.Queue });
            };

            foreach (MyPlayer player in ElementManager.Instance.GetByType<MyPlayer>())
            {
                player.Spawn(new Vector3(0, 0, 5), PedModel.ballas1);

                player.OnLogin += OnPlayerLogin;

                Task.Run(async () =>
                {
                    var result = await RpcManager.Instance.TriggerAsyncRpc<SingleCastRpc<string>>(player, "Async.RequestLocalization", new EmptyRpc());
                    Console.WriteLine($"Localization for {player.Name}: {result.Value}");
                });

                RpcManager.Instance.TriggerRPC(player, "queue", new EmptyRpc() { OnClientRpcFailed = ClientRpcFailedAction.Queue });
            }


            RpcManager.Instance.RegisterRPC<ElementRpc<Player>>("announce", (player, rpc) =>
            {
                ChatBox.WriteLine(rpc.Element.Name);
                RpcManager.Instance.TriggerRPC("announce-response", new EmptyRpc());
            });

            RpcManager.Instance.RegisterRPC<ElementRpc<Player>>("announce", (player, rpc) =>
            {
                ChatBox.WriteLine($"Number two: {rpc.Element.Name}");
            });

            RpcManager.Instance.RegisterAsyncRPC<SingleCastRpc<string>, EmptyRpc>("Async.RequestMapName", (player, request) =>
            {
                return new SingleCastRpc<string>(GameServer.Announcement.MapName);
            });

            //XmlStuff();
        }

        private void OnPlayerLogin(Player source, OnLoginEventArgs eventArgs)
        {
            Console.WriteLine(string.Format("{0} has logged in with the account: {1} (previous was {2})", source.Name, eventArgs.NewAccount.Name, eventArgs.PreviousAccount.Name));
        }

        public void XmlStuff()
        {
            XmlDocument document = new XmlDocument();
            document.Load("test.xml"); // Load test.xml from the root folder

            // Writes 1 to 5
            foreach (XmlElement item in document.FirstChild.FirstChild.ChildNodes)
            {
                Console.WriteLine(item.Value);
            }

            XmlElement newElement = document.CreateElement("new"); // Create a new element
            newElement.Value = "test";

            // Append the element to the first child (<test>)
            document.FirstChild.AppendChild(newElement);

            // Save the xml file
            document.Save("test.xml");
        }
    }

    public class KillMessagesResource : Resource
    {
        public KillMessagesResource() : base("killmessages")
        {
            this.OnStart += () => Console.WriteLine("TTT");
        }
    }

    [DefaultElementClass(ElementType.Player)]
    public class MyPlayer : Player
    {
        public MyPlayer(MtaElement element) : base(element)
        {
            OnSpawn += OnPlayerSpawn;
        }

        private void OnPlayerSpawn(Player source, OnSpawnEventArgs eventArgs)
        {
            Camera.Target = this;
            Camera.Fade(CameraFade.In);
        }
    }

    [DefaultElementClass(ElementType.Vehicle)]
    public class MyVehicle : Vehicle
    {
        public MyVehicle(MtaElement element) : base(element)
        {
            PrimaryColor = Color.ForestGreen;
            OnEnter += (BaseVehicle source, OnEnterEventArgs eventArgs) =>
            {
                eventArgs.Player.Model = (int)PedModel.army;
            };
        }

        public MyVehicle(Vector3 pos) : base(VehicleModel.Cars.Alpha, pos)
        {
            PrimaryColor = Color.ForestGreen;
        }

        [Export("DoTheThing")]
        public static void DoTheThing(string x)
        {
            Console.WriteLine("Export has been called with parameter {0}", x);
        }
    }
}
