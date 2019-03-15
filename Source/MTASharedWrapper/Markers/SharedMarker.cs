using System;
using System.Collections.Generic;
using System.Text;
using MultiTheftAuto;
using System.Numerics;

namespace MTASharedWrapper.Markers
{
    public class SharedMarker : PhysicalElement
    {

        public SharedMarker(Vector3 position, Color color, string theType = "checkpoint", float size = 4.0)
        {

        }


        internal SharedMarker(MTAElement marker) : base(marker)
        {

        }
    }
}
