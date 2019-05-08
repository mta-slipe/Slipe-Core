using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Numerics;
using Slipe.Shared.Utilities;
using Slipe.Shared.Radar;
using System.ComponentModel;
using Slipe.Shared.Elements;

namespace Slipe.Client.Radar
{
    /// <summary>
    /// Class representing a radar area on the minimap
    /// </summary>
    [DefaultElementClass(ElementType.RadarArea)]
    public class RadarArea : SharedRadarArea
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public RadarArea(MtaElement element) : base(element) { }

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
