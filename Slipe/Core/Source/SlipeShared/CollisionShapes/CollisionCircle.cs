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
    /// This is a shape that has a position and a radius and infinite height that you can use to detect a player's presence.
    /// </summary>
    public class CollisionCircle: CollisionShape
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public CollisionCircle(MtaElement element) : base(element)
        {

        }

        /// <summary>
        /// Creates a collision circle from a position and a radius
        /// </summary>
        public CollisionCircle(Vector2 position, float radius)
            : this(MtaShared.CreateColCircle(position.X, position.Y, radius)) { }
    }
}
