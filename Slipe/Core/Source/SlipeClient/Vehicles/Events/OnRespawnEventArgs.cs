using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Vehicles.Events
{
    public class OnRespawnEventArgs
    {
        /// <summary>
        /// True if the respawning vehicle exploded
        /// </summary>
        public bool Exploded { get; }

        internal OnRespawnEventArgs(dynamic b)
        {
            Exploded = (bool)b;
        }
    }
}
