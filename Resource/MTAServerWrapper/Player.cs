using MTASharedWrapper;
using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace MTAServerWrapper
{
    public class Player: SharedPlayer
    {
        public Player(MultiTheftAuto.Element mtaElement) : base(mtaElement)
        {
        }

        public int WantedLevel
        {
            set
            {
                Server.SetPlayerWantedLevel(element, value);
            }
        }

        public override string Name
        {
            get
            {
                return Shared.GetPlayerName(element);
            }
            set
            {
                Server.SetPlayerName(element, value);
            }
        }

        public void Spawn(Vector3 position, int rotation = 0, int skin = 0, int interior = 0, int dimension = 0)
        {
            //TODO: Add team parameter
            Server.SpawnPlayer(element, position.X, position.Y, position.Z, rotation, skin, interior, dimension, null);
        }
    }
}
