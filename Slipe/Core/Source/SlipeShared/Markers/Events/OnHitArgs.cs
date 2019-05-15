using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Markers.Events
{
    public class OnHitArgs
    {
        /// <summary>
        /// The element that hit this marker
        /// </summary>
        public PhysicalElement Element { get; }

        /// <summary>
        /// True if the dimensions of the two elements are matching, false otherwise
        /// </summary>
        public bool IsDimensionMatching { get; }

        internal OnHitArgs(PhysicalElement hitElement, bool matchingDimension)
        {
            Element = hitElement;
            IsDimensionMatching = matchingDimension;
        }
    }
}
