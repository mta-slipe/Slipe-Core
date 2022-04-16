using SlipeLua.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using SlipeLua.Shared.Elements;
using System.ComponentModel;

namespace SlipeLua.Shared.CollisionShapes
{
    /// <summary>
    /// This is a shape that has a position and a width and a depth.
    /// </summary>
    public class CollisionRectangle: CollisionShape
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public CollisionRectangle(MtaElement element) : base(element)
        {

        }

        /// <summary>
        /// Creates a rectangular collision shape. The position marks on the south west corner of the colshape.
        /// </summary>
        /// <param name="position">The bottom left position of the rectangle</param>
        /// <param name="dimensions">The length and width</param>
        public CollisionRectangle(Vector2 position, Vector2 dimensions)
            :this(MtaShared.CreateColRectangle(position.X, position.Y, dimensions.X, dimensions.Y)) { }
    }
}
