using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace MTASharedWrapper.CollisionShapes
{
    public class CollisionRectangle: CollisionShape
    {
        public CollisionRectangle(Vector2 position, float width, float height)
        {
            element = Shared.CreateColRectangle(position.X, position.Y, width, height);
            SharedElementManager.Instance.RegisterElement(this);
        }
    }
}
