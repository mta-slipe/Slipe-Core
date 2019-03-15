using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Slipe.Shared.CollisionShapes
{
    public class CollisionCircle: CollisionShape
    {
        public CollisionCircle(Vector2 position, float radius)
        {
            element = MTAShared.CreateColCircle(position.X, position.Y, radius);
            ElementManager.Instance.RegisterElement(this);
        }
    }
}
