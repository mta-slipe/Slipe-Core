using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Markers.Events
{
    public class OnLeaveEventArgs
    {
        /// <summary>
        /// The element that left the marker
        /// </summary>
        public PhysicalElement Element { get; }

        /// <summary>
        /// True if the dimensions of the elements are matching, false otherwise
        /// </summary>
        public bool IsDimensionMatching { get; }

        internal OnLeaveEventArgs(MtaElement leaveElement, dynamic matchingDimension)
        {
            Element = ElementManager.Instance.GetElement<PhysicalElement>(leaveElement);
            IsDimensionMatching = (bool) matchingDimension;
        }
    }
}
