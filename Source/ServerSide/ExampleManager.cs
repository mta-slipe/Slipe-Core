using Slipe.Server.IO;
using Slipe.Server.Peds;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ServerSide
{
    public class ExampleManager
    {
        public ExampleManager()
        {
            Player.OnJoin += OnPlayerJoin;
        }

        private void OnPlayerJoin(Player source, Slipe.Server.Peds.Events.OnJoinEventArgs eventArgs)
        {
            source.Spawn(new Vector3(0, 0, 3), Slipe.Shared.Peds.PedModel.ballas1);

            ChatBox.WriteLine($"{source.Name} has joined the server!");
        }
    }
}
