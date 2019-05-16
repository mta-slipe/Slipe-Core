using Slipe.MtaDefinitions;
using Slipe.Server.Pickups;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
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
