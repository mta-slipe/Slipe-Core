using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTASharedWrapper.CollisionShapes
{
    public class CollisionSphere: CollisionShape
    {
        public CollisionSphere(float x, float y, float z, float radius)
        {
            element = Shared.CreateColSphere(x, y, z, radius);
            SharedElementManager.Instance.RegisterElement(this);
        }
    }
}
