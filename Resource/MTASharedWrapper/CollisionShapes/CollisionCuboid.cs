using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTASharedWrapper.CollisionShapes
{
    public class CollisionCuboid: CollisionShape
    {
        public CollisionCuboid(float x, float y, float z, float width, float depth, float height)
        {
            element = Shared.CreateColCuboid(x, y, z, width, depth, height);
            SharedElementManager.Instance.RegisterElement(this);
        }
    }
}
