using SlipeLua.MtaDefinitions;
using SlipeLua.Server.Markers;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Peds.Events
{
    public class OnMarkerHitEventArgs
    {
        /// <summary>
        /// The marker that was hit
        /// </summary>
        public Marker Marker { get; }

        /// <summary>
        /// True if the dimensions of the elements are matching, false otherwise
        /// </summary>
        public bool IsDimensionMatching { get; }

        internal OnMarkerHitEventArgs(MtaElement markerHit, dynamic matchingDimension)
        {
            Marker = ElementManager.Instance.GetElement<Marker>(markerHit);
            IsDimensionMatching = (bool) matchingDimension;
        }
    }
}
