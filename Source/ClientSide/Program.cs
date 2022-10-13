using SlipeLua.Client.Dx;
using SlipeLua.Client.Game;
using SlipeLua.Client.IO;
using SlipeLua.Client.Peds;
using SlipeLua.Client.Rpc;
using SlipeLua.Client.Vehicles;
using SlipeLua.Shared.Rpc;
using System.Numerics;
using System.Threading.Tasks;

namespace ClientSide
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            RpcManager.Instance.TriggerRPC("announce", new ElementRpc<Player>(Player.Local));

            RpcManager.Instance.RegisterRPC<EmptyRpc>("announce-response", (rpc) =>
            {
                ChatBox.WriteLine("Hey, we responded!");
            });

            RpcManager.Instance.RegisterRPC<EmptyRpc>("queue", (rpc) =>
            {
                ChatBox.WriteLine("I was queued!");
            });

            RpcManager.Instance.RegisterAsyncRPC<SingleCastRpc<string>, EmptyRpc>("Async.RequestLocalization", (request) =>
            {
                return new SingleCastRpc<string>(GameClient.Localization.Item1);
            });

            Task.Run(async () =>
            {
                var responseRpc = await RpcManager.Instance.TriggerAsyncRpc<SingleCastRpc<string>>("Async.RequestMapName", new EmptyRpc());
                string name = responseRpc.Value;
                ChatBox.WriteLine($"Map name: {name}");
            });

            Dx.DrawCircle(Vector2.Zero, 4);

            var vehicle = new Vehicle(VehicleModel.Cars.Alpha, new Vector3(20, 20, 5), Vector3.Zero, "CLIENT");
            vehicle.OnStreamIn += (o, args) => ChatBox.WriteLine("Streamed in!");
            vehicle.OnStreamOut += (o, args) => ChatBox.WriteLine("Streamed out!");
        }
    }
}
