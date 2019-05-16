using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Peds.Events
{
    public class OnStuntFinishEventArgs
    {
        /// <summary>
        /// The type of stunt the player has performed
        /// </summary>
        public string StuntType { get; }

        /// <summary>
        /// The duration of the stunt
        /// </summary>
        public int Time { get; }

        /// <summary>
        /// The distance of the stunt
        /// </summary>
        public float Distance { get; }

        internal OnStuntFinishEventArgs(dynamic t, dynamic time, dynamic d)
        {
            StuntType = (string)t;
            Time = (int)time;
            Distance = (float)d;
        }
    }
}
