using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Slipe.Shared.CollisionShapes
{
    public class CollisionRectangle: CollisionShape
    {
        public CollisionRectangle(Vector2 position, float width, float height)
        {
            element = MTAShared.CreateColRectangle(position.X, position.Y, width, height);
            ElementManager.Instance.RegisterElement(this);
        }
    }
}
