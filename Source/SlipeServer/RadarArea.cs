using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared;
using Slipe.MTADefinitions;
using System.Numerics;

namespace Slipe.Server
{
    public class RadarArea : SharedRadarArea
    {
        public RadarArea(MTAElement element) : base (element) { }

        public RadarArea(Vector2 position, Vector2 dimensions, Color color, Element visibleTo = null) : base (position, dimensions, color, visibleTo) { }

        public RadarArea(Vector2 position, Vector2 dimension) : base (position, dimension) { }
    }
}
