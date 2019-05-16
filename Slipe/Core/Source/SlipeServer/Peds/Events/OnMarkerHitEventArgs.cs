using Slipe.MtaDefinitions;
using Slipe.Server.Markers;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
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
