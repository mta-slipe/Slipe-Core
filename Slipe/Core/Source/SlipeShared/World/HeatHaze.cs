using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Slipe.Shared.World
{
    /// <summary>
    /// Struct to define different heat haze properties in the GTA world
    /// </summary>
    public struct HeatHaze
    {
        #region Properties

        /// <summary>
        ///  The intensity of the effect, from 0 to 255.
        /// </summary>
        public int Intensity { get; set; }

        /// <summary>
        /// A random jitter, from 0 to 255.
        /// </summary>
        public int RandomShift { get; set; }

        /// <summary>
        /// The slowest effect speed, from 0 to 1000.
        /// </summary>
        public int SpeedMin { get; set; }

        /// <summary>
        /// The fastest effect speed, from 0 to 1000.
        /// </summary>
        public int SpeedMax { get; set; }

        /// <summary>
        /// Size in pixels of the chunk grabbed from the screen, from -1000 to 1000.
        /// </summary>
        public Vector2 ScanSize { get; set; }

        /// <summary>
        /// Size in pixels the chunk will be when rendered back to the screen, from 0 to 1000.
        /// </summary>
        public Vector2 RenderSize { get; set; }

        /// <summary>
        /// Set to true to enable the heat haze effect when inside a building.
        /// </summary>
        public bool ShowInside { get; set; }

        #endregion

        /// <summary>
        /// Create a heat haze struct
        /// </summary>
        public HeatHaze(int intensity, int randomShift, int speedMin, int speedMax, Vector2 scanSize, Vector2 renderSize, bool showInside = false)
        {
            Intensity = intensity;
            RandomShift = randomShift;
            SpeedMin = speedMin;
            SpeedMax = speedMax;
            ScanSize = scanSize;
            RenderSize = renderSize;
            ShowInside = showInside;
        }

        /// <summary>
        /// Heat haze with optional paramters as default
        /// </summary>
        public HeatHaze(int intensity = 0, int randomShift = 0, int speedMin = 12, int speedMax = 18) : this(intensity, randomShift, speedMin, speedMax, new Vector2(75, 80), new Vector2(80, 85)) { }

        /// <summary>
        /// Creates a heat haze from the raw MTA function output
        /// </summary>
        public static HeatHaze FromRaw(Tuple<int, int, int, int, int, int, int, Tuple<int, bool>> raw)
        {
            return new HeatHaze(raw.Item1, raw.Item2, raw.Item3, raw.Item4, new Vector2(raw.Item5, raw.Item6), new Vector2(raw.Item7, raw.Rest.Item1), raw.Rest.Item2);
        }



    }
}
