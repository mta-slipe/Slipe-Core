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
    /// This is a shape that has a position and a 2D (X/Y) radius and a height.
    /// </summary>
    public class CollisionTube: CollisionShape
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public CollisionTube(MtaElement element) : base(element)
        {

        }

        /// <summary>
        /// Creates a collision tube from a position, radius and height
        /// </summary>
        public CollisionTube(Vector3 position, float radius, float height)
            :this(MtaShared.CreateColTube(position.X, position.Y, position.Z, radius, height)) { }
    }
}
