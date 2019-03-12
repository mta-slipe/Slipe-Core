using MTASharedWrapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using MultiTheftAuto;

namespace MTAServerWrapper
{
    public class MTAObject : SharedObject 
    {
        public MTAObject(MTAElement element): base(element)
        {

        }

        public MTAObject(int model, Vector3 position) : base(model, position)
        {
        }

        public MTAObject(int model, Vector3 position, Vector3 rotation, bool isLowLOD = false) : base(model, position, rotation, isLowLOD)
        {
        }
    }
}
