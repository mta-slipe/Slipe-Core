using Slipe.Server.Markers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnMarkerLeaveArgs
    {
        /// <summary>
        /// The marker that was left
        /// </summary>
        public Marker Marker { get; }

        /// <summary>
        /// True if the elements are in the same dimension, false otherwise
        /// </summary>
        public bool IsDimensionMatching { get; }

        internal OnMarkerLeaveArgs(Marker markerLeft, bool matchingDimension)
        {
            Marker = markerLeft;
            IsDimensionMatching = matchingDimension;
        }
    }
}
