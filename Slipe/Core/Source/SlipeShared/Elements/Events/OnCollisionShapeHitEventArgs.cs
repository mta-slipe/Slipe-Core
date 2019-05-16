using Slipe.MtaDefinitions;
using Slipe.Shared.CollisionShapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Elements.Events
{
    public class OnCollisionShapeHitEventArgs
    {
        /// <summary>
        /// The collision shape that was hit
        /// </summary>
        public CollisionShape CollisionShape { get; }

        /// <summary>
        /// True if the dimension of both elements are matching, false otherwise
        /// </summary>
        public bool IsDimensionMatching { get; }

        internal OnCollisionShapeHitEventArgs(MtaElement colshape, dynamic matchingDimension)
        {
            CollisionShape = ElementManager.Instance.GetElement<CollisionShape>(colshape);
            IsDimensionMatching = (bool) matchingDimension;
        }
    }
}
