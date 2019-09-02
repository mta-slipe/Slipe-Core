using Slipe.Client.Dx;
using Slipe.Client.IO;
using Slipe.Client.Peds;
using Slipe.Client.Rpc;
using Slipe.Shared.Rpc;
using System.Numerics;

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

            Dx.DrawCircle(Vector2.Zero, 4);
        }
    }
}
