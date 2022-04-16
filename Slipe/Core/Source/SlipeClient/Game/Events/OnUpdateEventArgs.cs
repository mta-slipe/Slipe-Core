using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Game.Events
{
    public class OnUpdateEventArgs
    {
        /// <summary>
        /// The interval between this frame and the previous one in milliseconds.
        /// </summary>
        public float TimeSlice { get; }

        /// <summary>
        /// The interval between this frame and the previous one in seconds
        /// </summary>
        public float DeltaTime { get; }

        internal OnUpdateEventArgs(dynamic timeSlice)
        {
            TimeSlice = timeSlice;
            DeltaTime = timeSlice / 1000;
        }
    }
}
