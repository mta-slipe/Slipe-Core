using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Slipe.Shared.CollisionShapes
{
    /// <summary>
    /// This is a shape that has a position and a radius.
    /// </summary>
    public class CollisionSphere: CollisionShape
    {
        /// <summary>
        /// Creates a collision sphere from a position and radius
        /// </summary>
        public CollisionSphere(Vector3 position, float radius)
        {
            element = MTAShared.CreateColSphere(position.X, position.Y, position.Z, radius);
            ElementManager.Instance.RegisterElement(this);
        }
    }
}
