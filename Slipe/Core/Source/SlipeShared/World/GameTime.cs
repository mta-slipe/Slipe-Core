using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.World
{
    /// <summary>
    /// Class representing a game time, contrary to real time
    /// </summary>
    public struct GameTime
    {
        public int Hour { get; set; }
        public int Minute { get; set; }

        /// <summary>
        /// Create a game time from hours and minutes
        /// </summary>
        public GameTime(int hour, int minute)
        {
            Hour = Math.Clamp(hour, 0, 23);
            Minute = Math.Clamp(minute, 0, 59);
        }

        /// <summary>
        /// Create a game time from a datetime
        /// </summary>
        public GameTime(DateTime time)
        {
            Hour = time.Hour;
            Minute = time.Minute;
        }
    }
}
