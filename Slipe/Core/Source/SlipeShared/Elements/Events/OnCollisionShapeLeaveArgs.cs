using Slipe.Shared.CollisionShapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Elements.Events
{
    public class OnCollisionShapeLeaveArgs
    {
        /// <summary>
        /// The collision shape that was left
        /// </summary>
        public CollisionShape CollisionShape { get; }

        /// <summary>
        /// True if the dimension of both elements are matching, false otherwise
        /// </summary>
        public bool IsDimensionMatching { get; }

        internal OnCollisionShapeLeaveArgs(CollisionShape colshape, bool matchingDimension)
        {
            CollisionShape = colshape;
            IsDimensionMatching = matchingDimension;
        }
    }
}
