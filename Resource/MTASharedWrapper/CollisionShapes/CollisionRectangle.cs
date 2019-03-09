using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTASharedWrapper.CollisionShapes
{
    public class CollisionRectangle: CollisionShape
    {
        public CollisionRectangle(float x, float y, float width, float height)
        {
            element = Shared.CreateColRectangle(x, y, width, height);
            SharedElementManager.Instance.RegisterElement(this);
        }
    }
}
