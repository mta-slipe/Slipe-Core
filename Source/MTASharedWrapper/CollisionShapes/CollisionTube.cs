using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace MTASharedWrapper.CollisionShapes
{
    public class CollisionTube: CollisionShape
    {
        public CollisionTube(Vector3 position, float radius, float height)
        {
            element = Shared.CreateColTube(position.X, position.Y, position.Z, radius, height);
            ElementManager.Instance.RegisterElement(this);
        }
    }
}
