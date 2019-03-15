using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Slipe.Shared.CollisionShapes
{
    public class CollisionCuboid: CollisionShape
    {
        public CollisionCuboid(Vector3 position, float width, float depth, float height)
        {
            element = MTAShared.CreateColCuboid(position.X, position.Y, position.Z, width, depth, height);
            ElementManager.Instance.RegisterElement(this);
        }
    }
}
