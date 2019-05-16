using Slipe.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnNetworkInteruptionEventArgs
    {
        /// <summary>
        /// The status of the network interuption
        /// </summary>
        public NetworkInteruptionStatus Status { get; }

        /// <summary>
        /// The ticks since the interruption started.
        /// </summary>
        public int Ticks { get; }

        internal OnNetworkInteruptionEventArgs(dynamic status, dynamic ticksSinceInteruptionStarted)
        {
            Status = (NetworkInteruptionStatus) status;
            Ticks = (int) ticksSinceInteruptionStarted;
        }
    }
}
