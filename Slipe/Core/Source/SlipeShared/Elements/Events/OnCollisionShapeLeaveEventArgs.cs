﻿using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.CollisionShapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Shared.Elements.Events
{
    public class OnCollisionShapeLeaveEventArgs
    {
        /// <summary>
        /// The collision shape that was left
        /// </summary>
        public CollisionShape CollisionShape { get; }

        /// <summary>
        /// True if the dimension of both elements are matching, false otherwise
        /// </summary>
        public bool IsDimensionMatching { get; }

        internal OnCollisionShapeLeaveEventArgs(MtaElement colshape, dynamic matchingDimension)
        {
            CollisionShape = ElementManager.Instance.GetElement<CollisionShape>(colshape);
            IsDimensionMatching = (bool) matchingDimension;
        }
    }
}
