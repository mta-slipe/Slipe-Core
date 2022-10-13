using SlipeLua.Server.IO;
using SlipeLua.Server.Peds;
using System.Numerics;

namespace ServerSide
{
    public class ExampleManager
    {
        public ExampleManager()
        {
            Player.OnJoin += OnPlayerJoin;
        }

        private void OnPlayerJoin(Player source, SlipeLua.Server.Peds.Events.OnJoinEventArgs eventArgs)
        {
            source.Spawn(new Vector3(0, 0, 3), SlipeLua.Shared.Peds.PedModel.ballas1);

            ChatBox.WriteLine($"{source.Name} has joined the server!");
        }
    }
}
