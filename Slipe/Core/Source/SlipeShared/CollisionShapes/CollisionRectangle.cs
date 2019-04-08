using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.Shared.Elements;

namespace Slipe.Shared.CollisionShapes
{
    /// <summary>
    /// This is a shape that has a position and a width and a depth.
    /// </summary>
    public class CollisionRectangle: CollisionShape
    {
        /// <summary>
        /// Creates a rectangular collision shape. The position marks on the south west corner of the colshape.
        /// </summary>
        public CollisionRectangle(Vector2 position, float width, float height)
        {
            element = MTAShared.CreateColRectangle(position.X, position.Y, width, height);
            ElementManager.Instance.RegisterElement(this);
        }
    }
}
