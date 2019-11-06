using Slipe.MtaDefinitions;
using Slipe.Server.Peds;
using Slipe.Server.Peds.Events;
using Slipe.Server.Vehicles;
using Slipe.Shared.Elements;
using Slipe.Shared.Peds;
using Slipe.Shared.Utilities;
using System;
using System.Numerics;
using Slipe.Shared.Rendering;
using Slipe.Sql;
using System.Threading.Tasks;
using Slipe.Shared.Exports;
using Slipe.Server.Vehicles.Events;
using Slipe.Server.Accounts;
using Slipe.Server.Resources;
using Slipe.Server.Rpc;
using Slipe.Shared.Rpc;
using Slipe.Server.IO;
using Slipe.Server.Game;
using Slipe.Server.GameWorld;

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
            new KillMessagesResource().Start();

            // Spawn a player in Blueberry
            Player.OnJoin += (Player source, OnJoinEventArgs eventArgs) =>
            {
                source.Spawn(new Vector3(0, 0, 5), PedModel.ballas1);

                source.OnLogin += OnPlayerLogin;
            };

            foreach (MyPlayer player in ElementManager.Instance.GetByType<MyPlayer>())
            {
                player.Spawn(new Vector3(0, 0, 5), PedModel.ballas1);

                player.OnLogin += OnPlayerLogin;

                Task.Run(async () => {
                    var result = await RpcManager.Instance.TriggerAsyncRpc<SingleCastRpc<string>>(player, "Async.RequestLocalization", new EmptyRpc());
                    Console.WriteLine($"Localization for {player.Name}: {result.Value}");
                });
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

        }

        private void OnPlayerLogin(Player source, OnLoginEventArgs eventArgs)
        {
            Console.WriteLine(string.Format("{0} has logged in with the account: {1} (previous was {2})", source.Name, eventArgs.NewAccount.Name, eventArgs.PreviousAccount.Name));
        }
    }

    public class KillMessagesResource: Resource
    {
        public KillMessagesResource(): base("killmessages")
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
        public static void DoTheThing(string x) {
            Console.WriteLine("Export has been called with parameter {0}", x);
        }

    }

}
