using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Shared.CollisionShapes.Events
{
    public class OnLeaveEventArgs
    {
        /// <summary>
        /// The element that left the collision shape
        /// </summary>
        public PhysicalElement Element { get; }

        /// <summary>
        /// True if the dimensions of the collision shape and the element are matching
        /// </summary>
        public bool IsDimensionMatching { get; }

        internal OnLeaveEventArgs(MtaElement element, dynamic matchingDimension)
        {
            Element = ElementManager.Instance.GetElement<PhysicalElement>(element);
            IsDimensionMatching = (bool) matchingDimension;
        }
    }
}
