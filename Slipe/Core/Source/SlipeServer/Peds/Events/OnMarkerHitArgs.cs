using Slipe.Server.Markers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnMarkerHitArgs
    {
        /// <summary>
        /// The marker that was hit
        /// </summary>
        public Marker Marker { get; }

        /// <summary>
        /// True if the dimensions of the elements are matching, false otherwise
        /// </summary>
        public bool IsDimensionMatching { get; }

        internal OnMarkerHitArgs(Marker markerHit, bool matchingDimension)
        {
            Marker = markerHit;
            IsDimensionMatching = matchingDimension;
        }
    }
}
