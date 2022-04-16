using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Shared.GameWorld
{
    /// <summary>
    /// Represents the weather in the world
    /// </summary>
    public struct Weather
    {
        private int _from;
        private int _to;

        /// <summary>
        /// Get and set the current weather value
        /// </summary>
        public WeatherType Current
        {
            get
            {
                return (WeatherType)_from;
            }
            set
            {
                _from = (int)value;
            }
        }

        /// <summary>
        /// Get and set the transitioning weather
        /// </summary>
        public WeatherType TransitionTo
        {
            get
            {
                return (WeatherType)_to;
            }
            set
            {
                _to = (int)value;
            }
        }

        /// <summary>
        /// Creates a weather struct that represents a transitioning weather
        /// </summary>
        public Weather(WeatherType current, WeatherType transitionTo)
        {
            _from = (int)current;
            _to = (int)transitionTo;
        }

        /// <summary>
        /// Creates a weather struct representing a single weather state
        /// </summary>
        public Weather(WeatherType weather)
        {
            _from = (int)weather;
            _to = -1;
        }



    }
}
