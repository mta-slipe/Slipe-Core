using Slipe.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Game.Events
{
    public class OnNetworkInteruptionEventArgs
    {
        /// <summary>
        /// The status of the interuption
        /// </summary>
        public NetworkInteruptionStatus Status { get; }

        /// <summary>
        /// Ticks since the start of the interuption
        /// </summary>
        public int Ticks { get; }

        internal OnNetworkInteruptionEventArgs(dynamic status, dynamic ticksSinceInteruptionStarted)
        {
            Status = (NetworkInteruptionStatus)status;
            Ticks = (int)ticksSinceInteruptionStarted;
        }
    }
}
