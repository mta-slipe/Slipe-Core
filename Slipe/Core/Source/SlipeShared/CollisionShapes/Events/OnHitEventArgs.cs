using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.CollisionShapes.Events
{
    public class OnHitEventArgs
    {
        /// <summary>
        /// The element that hit the collision shape
        /// </summary>
        public PhysicalElement Element { get; }

        /// <summary>
        /// True if the dimensions of the collision shape and the element are matching
        /// </summary>
        public bool IsDimensionMatching { get; }

        internal OnHitEventArgs(MtaElement element, dynamic matchingDimension)
        {
            Element = ElementManager.Instance.GetElement<PhysicalElement>(element);
            IsDimensionMatching = (bool) matchingDimension;
        }
    }
}
