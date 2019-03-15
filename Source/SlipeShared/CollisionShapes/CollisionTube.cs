using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Slipe.Shared.CollisionShapes
{
    public class CollisionTube: CollisionShape
    {
        public CollisionTube(Vector3 position, float radius, float height)
        {
            element = MTAShared.CreateColTube(position.X, position.Y, position.Z, radius, height);
            ElementManager.Instance.RegisterElement(this);
        }
    }
}
