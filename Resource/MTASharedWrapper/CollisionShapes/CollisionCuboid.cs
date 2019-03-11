using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace MTASharedWrapper.CollisionShapes
{
    public class CollisionCuboid: CollisionShape
    {
        public CollisionCuboid(Vector3 position, float width, float depth, float height)
        {
            element = Shared.CreateColCuboid(position.X, position.Y, position.Z, width, depth, height);
            SharedElementManager.Instance.RegisterElement(this);
        }
    }
}
