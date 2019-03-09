using MTASharedWrapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTAServerWrapper
{
    public class MTAObject : SharedObject 
    {
        public MTAObject(int model, Vector3 position) : base(model, position)
        {
        }

        public MTAObject(int model, Vector3 position, Vector3 rotation, bool isLowLOD = false) : base(model, position, rotation, isLowLOD)
        {
        }
    }
}
