using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Sounds.Events
{
    public class OnBeatEventArgs
    {
        /// <summary>
        /// The position in the song of the beat
        /// </summary>
        public float Time { get; }

        internal OnBeatEventArgs(dynamic t)
        {
            Time = (float)t;
        }
    }
}
