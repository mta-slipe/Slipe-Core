using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Game.Events
{
    public class OnUpdateEventArgs
    {
        /// <summary>
        /// The interval between this frame and the previous one in milliseconds.
        /// </summary>
        public float Delta { get; }

        internal OnUpdateEventArgs(dynamic timeSlice)
        {
            Delta = timeSlice;
        }
    }
}
