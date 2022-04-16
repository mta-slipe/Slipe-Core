using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;
using System.Numerics;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Utilities;
using SlipeLua.Shared.Radar;
using System.ComponentModel;

namespace SlipeLua.Server.Radar
{
    /// <summary>
    /// Class representing radar areas
    /// </summary>
    [DefaultElementClass(ElementType.RadarArea)]
    public class RadarArea : SharedRadarArea
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public RadarArea(MtaElement element) : base(element) { }

        /// <summary>
        /// Create a radar area from all the createRadarArea parameters
        /// </summary>
        public RadarArea(Vector2 position, Vector2 dimensions, Color color, Element visibleTo = null) : base(position, dimensions, color, visibleTo) { }

        /// <summary>
        /// Create a radar area only from dimensions
        /// </summary>
        public RadarArea(Vector2 position, Vector2 dimension) : base(position, dimension) { }
    }
}
