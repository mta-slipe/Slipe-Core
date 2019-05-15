using Slipe.Server.Pickups;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnPickupHitArgs
    {
        /// <summary>
        /// The pickup
        /// </summary>
        public Pickup Pickup { get; }

        internal OnPickupHitArgs(Pickup pickup)
        {
            Pickup = pickup;
        }
    }
}
