using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Enums;

namespace Slipe.Shared.Structs
{
    /// <summary>
    /// Represents the weather in the world
    /// </summary>
    public struct Weather
    {
        private int _from;
        private int _to;

        /// <summary>
        /// Creates a weather struct that represents a transitioning weather
        /// </summary>
        public Weather(WeatherEnum current, WeatherEnum transitionTo)
        {
            _from = (int) current;
            _to = (int) transitionTo;
        }

        /// <summary>
        /// Creates a weather struct representing a single weather state
        /// </summary>
        public Weather(WeatherEnum weather)
        {
            _from = (int)weather;
            _to = -1;
        }

        /// <summary>
        /// Get and set the current weather value
        /// </summary>
        public WeatherEnum Current
        {
            get
            {
                return (WeatherEnum) _from;
            }
            set
            {
                _from = (int)value;
            }
        }

        /// <summary>
        /// Get and set the transitioning weather
        /// </summary>
        public WeatherEnum TransitionTo
        {
            get
            {
                return (WeatherEnum)_to;
            }
            set
            {
                _to = (int)value;
            }
        }

    }
}
