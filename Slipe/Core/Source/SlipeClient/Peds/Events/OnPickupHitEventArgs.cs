using SlipeLua.Client.Pickups;
using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Peds.Events
{
    public class OnPickupHitEventArgs
    {
        /// <summary>
        /// The pickup
        /// </summary>
        public Pickup Pickup { get; }

        /// <summary>
        /// True if the dimensions of the elements are the same
        /// </summary>
        public bool IsDimensionMatching { get; }

        internal OnPickupHitEventArgs(MtaElement pickup, dynamic dim)
        {
            Pickup = ElementManager.Instance.GetElement<Pickup>(pickup);
            IsDimensionMatching = (bool)dim;
        }
    }
}
