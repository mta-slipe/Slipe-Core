using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.CollisionShapes.Events
{
    public class OnLeaveArgs
    {
        /// <summary>
        /// The element that left the collision shape
        /// </summary>
        public PhysicalElement Element { get; }

        /// <summary>
        /// True if the dimensions of the collision shape and the element are matching
        /// </summary>
        public bool IsDimensionMatching { get; }

        internal OnLeaveArgs(PhysicalElement element, bool matchingDimension)
        {
            Element = element;
            IsDimensionMatching = matchingDimension;
        }
    }
}
