using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.Shared.Elements;

namespace Slipe.Shared.CollisionShapes
{
    /// <summary>
    /// This is a shape that has a position and a radius and infinite height that you can use to detect a player's presence.
    /// </summary>
    public class CollisionCircle: CollisionShape
    {
        /// <summary>
        /// Creates a collision circle from a position and a radius
        /// </summary>
        public CollisionCircle(Vector2 position, float radius)
        {
            element = MtaShared.CreateColCircle(position.X, position.Y, radius);
            ElementManager.Instance.RegisterElement(this);
        }
    }
}
