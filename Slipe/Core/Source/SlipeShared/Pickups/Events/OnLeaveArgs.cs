using Slipe.Shared.Peds;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Pickups.Events
{
    public class OnLeaveArgs
    {
        /// <summary>
        /// The player that left the pickup
        /// </summary>
        public SharedPed Player { get; }

        /// <summary>
        /// True if the dimensions of the elements are matching, false otherwise
        /// </summary>
        public bool IsDimensionMatching { get; }

        internal OnLeaveArgs(SharedPed leavePlayer, bool matchingDimension)
        {
            Player = leavePlayer;
            IsDimensionMatching = matchingDimension;
        }
    }
}
