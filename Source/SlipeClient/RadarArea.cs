using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared;
using Slipe.MTADefinitions;
using System.Numerics;

namespace Slipe.Client
{
    public class RadarArea : SharedRadarArea
    {
        public RadarArea(MTAElement element) : base(element) { }

        public RadarArea(Vector2 position, Vector2 dimensions, Color color) : base(position, dimensions, color) { }

        public RadarArea(Vector2 position, Vector2 dimension) : base(position, dimension) { }
    }
}
