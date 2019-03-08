using MTASharedWrapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTAServerWrapper
{
    public class ServerObject : SharedObject
    {
        public ServerObject(int model, Vector3 position) : base(model, position)
        {
        }

        public ServerObject(int model, Vector3 position, Vector3 rotation, bool isLowLOD = false) : base(model, position, rotation, isLowLOD)
        {
        }
    }
}
