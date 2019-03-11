using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace MTASharedWrapper.CollisionShapes
{
    public class CollisionCircle: CollisionShape
    {
        public CollisionCircle(Vector2 position, float radius)
        {
            element = Shared.CreateColCircle(position.X, position.Y, radius);
            SharedElementManager.Instance.RegisterElement(this);
        }
    }
}
