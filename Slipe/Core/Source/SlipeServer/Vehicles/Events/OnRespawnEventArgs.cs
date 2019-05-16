using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Vehicles.Events
{
    public class OnRespawnEventArgs
    {
        /// <summary>
        /// True if the vehicle respawns after being exploded
        /// </summary>
        public bool IsExploded { get; }

        internal OnRespawnEventArgs(dynamic exploded)
        {
            IsExploded = (bool) exploded;
        }
    }
}
