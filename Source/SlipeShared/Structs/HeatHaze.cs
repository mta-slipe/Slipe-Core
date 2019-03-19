using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Slipe.Shared.Structs
{
    /// <summary>
    /// Struct to define different heat haze properties in the GTA world
    /// </summary>
    public struct HeatHaze
    {
        private int _intensity;
        private int _randomShift;
        private int _speedMin;
        private int _speedMax;
        private Vector2 _scanSize;
        private Vector2 _renderSize;
        private bool _showInside;

        /// <summary>
        /// Create a heat haze struct
        /// </summary>
        public HeatHaze(int intensity, int randomShift, int speedMin, int speedMax, Vector2 scanSize, Vector2 renderSize, bool showInside = false)
        {
            _intensity = intensity;
            _randomShift = randomShift;
            _speedMin = speedMin;
            _speedMax = speedMax;
            _scanSize = scanSize;
            _renderSize = renderSize;
            _showInside = showInside;
        }

        /// <summary>
        /// Heat haze with optional paramters as default
        /// </summary>
        public HeatHaze(int intensity = 0, int randomShift = 0, int speedMin = 12, int speedMax = 18) : this (intensity, randomShift, speedMin, speedMax, new Vector2(75, 80), new Vector2(80, 85)) { }

        /// <summary>
        /// Creates a heat haze from the raw MTA function output
        /// </summary>
        public static HeatHaze FromRaw(Tuple<int, int, int, int, int, int, int, Tuple<int, bool>> raw)
        {
            return new HeatHaze(raw.Item1, raw.Item2, raw.Item3, raw.Item4, new Vector2(raw.Item5, raw.Item6), new Vector2(raw.Item7, raw.Rest.Item1), raw.Rest.Item2);
        }

        /// <summary>
        ///  The intensity of the effect, from 0 to 255.
        /// </summary>
        public int Intensity
        {
            get
            {
                return _intensity;
            }
            set
            {
                _intensity = value;
            }
        }

        /// <summary>
        /// A random jitter, from 0 to 255.
        /// </summary>
        public int RandomShift
        {
            get
            {
                return _randomShift;
            }
            set
            {
                _randomShift = value;
            }
        }

        /// <summary>
        /// The slowest effect speed, from 0 to 1000.
        /// </summary>
        public int SpeedMin
        {
            get
            {
                return _speedMin;
            }
            set
            {
                _speedMin = value;
            }
        }

        /// <summary>
        /// The fastest effect speed, from 0 to 1000.
        /// </summary>
        public int SpeedMax
        {
            get
            {
                return _speedMax;
            }
            set
            {
                _speedMax = value;
            }
        }

        /// <summary>
        /// Size in pixels of the chunk grabbed from the screen, from -1000 to 1000.
        /// </summary>
        public Vector2 ScanSize
        {
            get
            {
                return _scanSize;
            }
            set
            {
                _scanSize = value;
            }
        }

        /// <summary>
        /// Size in pixels the chunk will be when rendered back to the screen, from 0 to 1000.
        /// </summary>
        public Vector2 RenderSize
        {
            get
            {
                return _renderSize;
            }
            set
            {
                _renderSize = value;
            }
        }

        /// <summary>
        /// Set to true to enable the heat haze effect when inside a building.
        /// </summary>
        public bool ShowInside
        {
            get
            {
                return _showInside;
            }
            set
            {
                _showInside = value;
            }
        }

    }
}
