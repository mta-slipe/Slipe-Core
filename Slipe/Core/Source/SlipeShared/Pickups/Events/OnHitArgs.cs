using Slipe.Shared.Peds;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Pickups.Events
{
    public class OnHitArgs
    {
        /// <summary>
        /// The player that hit this pickup
        /// </summary>
        public SharedPed Player { get; }

        /// <summary>
        /// True if the dimensions of the two elements are matching, false otherwise
        /// </summary>
        public bool IsDimensionMatching { get; }

        internal OnHitArgs(SharedPed hitPlayer, bool matchingDimension)
        {
            Player = hitPlayer;
            IsDimensionMatching = matchingDimension;
        }
    }
}
