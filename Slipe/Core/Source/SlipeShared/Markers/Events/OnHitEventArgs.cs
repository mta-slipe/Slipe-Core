using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Shared.Markers.Events
{
    public class OnHitEventArgs
    {
        /// <summary>
        /// The element that hit this marker
        /// </summary>
        public PhysicalElement Element { get; }

        /// <summary>
        /// True if the dimensions of the two elements are matching, false otherwise
        /// </summary>
        public bool IsDimensionMatching { get; }

        internal OnHitEventArgs(MtaElement hitElement, dynamic matchingDimension)
        {
            Element = ElementManager.Instance.GetElement<PhysicalElement>(hitElement);
            IsDimensionMatching = (bool) matchingDimension;
        }
    }
}
