using Slipe.Client.Dx;
using Slipe.Client.Game;
using Slipe.Client.IO;
using Slipe.Client.Peds;
using Slipe.Client.Rpc;
using Slipe.Shared.Rpc;
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
        }
    }
}
