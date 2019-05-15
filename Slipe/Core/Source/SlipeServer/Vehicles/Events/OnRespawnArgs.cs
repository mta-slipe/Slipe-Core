using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Vehicles.Events
{
    public class OnRespawnArgs
    {
        /// <summary>
        /// True if the vehicle respawns after being exploded
        /// </summary>
        public bool IsExploded { get; }

        internal OnRespawnArgs(bool exploded)
        {
            IsExploded = exploded;
        }
    }
}
