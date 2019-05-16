using Slipe.Client.Pickups;
using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Peds.Events
{
    public class OnPickupLeaveEventArgs
    {
        /// <summary>
        /// The pickup
        /// </summary>
        public Pickup Pickup { get; }

        /// <summary>
        /// True if the dimensions of the elements are the same
        /// </summary>
        public bool IsDimensionMatching { get; }

        internal OnPickupLeaveEventArgs(MtaElement pickup, dynamic dim)
        {
            Pickup = ElementManager.Instance.GetElement<Pickup>(pickup);
            IsDimensionMatching = (bool)dim;
        }
    }
}
