using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTASharedWrapper.CollisionShapes
{
    public class CollisionTube: CollisionShape
    {
        public CollisionTube(float x, float y, float z, float radius, float height)
        {
            element = Shared.CreateColTube(x, y, z, radius, height);
            ElementManager.Instance.RegisterElement(this);
        }
    }
}
