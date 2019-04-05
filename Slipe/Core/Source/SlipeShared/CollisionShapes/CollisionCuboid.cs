using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.Shared.Elements;

namespace Slipe.Shared.CollisionShapes
{
    /// <summary>
    /// This is a shape that has a position, width, depth and height.
    /// </summary>
    public class CollisionCuboid: CollisionShape
    {
        /// <summary>
        /// Creates a colision cuboid.  The position of the col starts at the southwest bottom corner of the shape.
        /// </summary>
        public CollisionCuboid(Vector3 position, float width, float depth, float height)
        {
            element = MTAShared.CreateColCuboid(position.X, position.Y, position.Z, width, depth, height);
            ElementManager.Instance.RegisterElement(this);
        }
    }
}
