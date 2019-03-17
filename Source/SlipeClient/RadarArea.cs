using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared;
using Slipe.MTADefinitions;
using System.Numerics;

namespace Slipe.Client
{
    /// <summary>
    /// Class representing a radar area on the minimap
    /// </summary>
    public class RadarArea : SharedRadarArea
    {
        /// <summary>
        /// Create a radar area from an MTA radar area element
        /// </summary>
        public RadarArea(MTAElement element) : base(element) { }

        /// <summary>
        /// Create a radar area from all createRadarArea paramters
        /// </summary>
        public RadarArea(Vector2 position, Vector2 dimensions, Color color) : base(position, dimensions, color) { }

        /// <summary>
        /// Create a radar area at a position using some dimensions
        /// </summary>
        public RadarArea(Vector2 position, Vector2 dimensions) : base(position, dimensions) { }
    }
}
