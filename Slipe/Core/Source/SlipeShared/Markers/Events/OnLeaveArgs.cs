using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Markers.Events
{
    public class OnLeaveArgs
    {
        /// <summary>
        /// The element that left the marker
        /// </summary>
        public PhysicalElement Element { get; }

        /// <summary>
        /// True if the dimensions of the elements are matching, false otherwise
        /// </summary>
        public bool IsDimensionMatching { get; }

        internal OnLeaveArgs(PhysicalElement leaveElement, bool matchingDimension)
        {
            Element = leaveElement;
            IsDimensionMatching = matchingDimension;
        }
    }
}
