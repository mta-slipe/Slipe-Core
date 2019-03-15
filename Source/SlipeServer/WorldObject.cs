using Slipe.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;

namespace Slipe.Server
{
    public class WorldObject : SharedWorldObject
    {
        public WorldObject(MTAElement element): base(element)
        {

        }

        public WorldObject(int model, Vector3 position) : base(model, position)
        {
        }

        public WorldObject(int model, Vector3 position, Vector3 rotation, bool isLowLOD = false) : base(model, position, rotation, isLowLOD)
        {
        }
    }
}
