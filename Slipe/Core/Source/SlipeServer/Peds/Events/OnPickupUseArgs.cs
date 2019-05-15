using Slipe.Server.Pickups;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnPickupUseArgs
    {
        /// <summary>
        /// The pickup
        /// </summary>
        public Pickup Pickup { get; }

        internal OnPickupUseArgs(Pickup pickup)
        {
            Pickup = pickup;
        }
    }
}
