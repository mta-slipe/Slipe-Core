using SlipeLua.MtaDefinitions;
using SlipeLua.Server.Pickups;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Peds.Events
{
    public class OnPickupLeaveEventArgs
    {
        /// <summary>
        /// The pickup
        /// </summary>
        public Pickup Pickup { get; }

        internal OnPickupLeaveEventArgs(MtaElement pickup)
        {
            Pickup = ElementManager.Instance.GetElement<Pickup>(pickup);
        }
    }
}
