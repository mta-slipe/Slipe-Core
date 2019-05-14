using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.CollisionShapes.Events
{
    public class OnHitArgs
    {
        /// <summary>
        /// The element that hit the collision shape
        /// </summary>
        public PhysicalElement Element { get; }

        /// <summary>
        /// True if the dimensions of the collision shape and the element are matching
        /// </summary>
        public bool IsDimensionMatching { get; }

        internal OnHitArgs(PhysicalElement element, bool matchingDimension)
        {
            Element = element;
            IsDimensionMatching = matchingDimension;
        }
    }
}
