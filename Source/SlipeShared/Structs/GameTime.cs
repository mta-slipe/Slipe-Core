using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Structs
{
    /// <summary>
    /// Class representing a game time, contrary to real time
    /// </summary>
    public struct GameTime
    {
        private int _hour;
        private int _minute;

        /// <summary>
        /// Create a game time from hours and minutes
        /// </summary>
        public GameTime(int hour, int minute)
        {
            _hour = Math.Clamp(hour, 0, 23);
            _minute = Math.Clamp(minute, 0, 59);
        }

        /// <summary>
        /// Create a game time from a datetime
        /// </summary>
        public GameTime(DateTime time)
        {
            _hour = time.Hour;
            _minute = time.Minute;
        }

        public int Hour
        {
            get
            {
                return _hour;
            }
            set
            {
                _hour = value;
            }
        }

        public int Minute
        {
            get
            {
                return _minute;
            }
            set
            {
                _minute = value;
            }
        }
    }
}
