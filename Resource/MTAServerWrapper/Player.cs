using MTASharedWrapper;
using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTAServerWrapper
{
    class Player: SharedPlayer
    {

        public int WantedLevel
        {
            set
            {
                Server.SetPlayerWantedLevel(element, value);
            }
        }

        public void Spawn(Vector3 position, int rotation = 0, int skin = 0, int interior = 0, int dimension = 0)
        {
            //TODO: Add team parameter
            Server.SpawnPlayer(element, position.x, position.y, position.z, rotation, skin, interior, dimension, null);
        }
    }
}
