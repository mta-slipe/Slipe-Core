using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.Shared.Elements;
using System.ComponentModel;

namespace Slipe.Shared.CollisionShapes
{
    /// <summary>
    /// This is a shape that has a position, width, depth and height.
    /// </summary>
    public class CollisionCuboid: CollisionShape
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public CollisionCuboid(MtaElement element) : base(element)
        {

        }

        /// <summary>
        /// Creates a colision cuboid.  The position of the col starts at the southwest bottom corner of the shape.
        /// </summary>
        /// <param name="position">The position of the south western corner</param>
        /// <param name="dimensions">The length, width and depth of the cuboid</param>
        public CollisionCuboid(Vector3 position, Vector3 dimensions) 
            : this(MtaShared.CreateColCuboid(position.X, position.Y, position.Z, dimensions.X, dimensions.Y, dimensions.Z)) { }
    }
}
