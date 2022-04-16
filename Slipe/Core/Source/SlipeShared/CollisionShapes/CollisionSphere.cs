﻿using SlipeLua.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using SlipeLua.Shared.Elements;
using System.ComponentModel;

namespace SlipeLua.Shared.CollisionShapes
{
    /// <summary>
    /// This is a shape that has a position and a radius.
    /// </summary>
    public class CollisionSphere: CollisionShape
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public CollisionSphere(MtaElement element) : base(element)
        {

        }

        /// <summary>
        /// Creates a collision sphere from a position and radius
        /// </summary>
        public CollisionSphere(Vector3 position, float radius)
            : this(MtaShared.CreateColSphere(position.X, position.Y, position.Z, radius)) { }
    }
}
