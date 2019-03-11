using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTASharedWrapper.CollisionShapes
{
    public class CollisionCircle: CollisionShape
    {
        public CollisionCircle(float x, float y, float radius)
        {
            element = Shared.CreateColCircle(x, y, radius);
            ElementManager.Instance.RegisterElement(this);
        }
    }
}
