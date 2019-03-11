using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace MTASharedWrapper.CollisionShapes
{
    public class CollisionSphere: CollisionShape
    {
        public CollisionSphere(Vector3 position, float radius)
        {
            element = Shared.CreateColSphere(position.X, position.Y, position.Z, radius);
            SharedElementManager.Instance.RegisterElement(this);
        }
    }
}
