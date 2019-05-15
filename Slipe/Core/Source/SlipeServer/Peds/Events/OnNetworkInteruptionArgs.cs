using Slipe.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnNetworkInteruptionArgs
    {
        /// <summary>
        /// The status of the network interuption
        /// </summary>
        public NetworkInteruptionStatus Status { get; }

        /// <summary>
        /// The ticks since the interruption started.
        /// </summary>
        public int Ticks { get; }

        internal OnNetworkInteruptionArgs(NetworkInteruptionStatus status, int ticksSinceInteruptionStarted)
        {
            Status = status;
            Ticks = ticksSinceInteruptionStarted;
        }
    }
}
