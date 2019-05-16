using Slipe.MtaDefinitions;
using Slipe.Server.Markers;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnMarkerLeaveEventArgs
    {
        /// <summary>
        /// The marker that was left
        /// </summary>
        public Marker Marker { get; }

        /// <summary>
        /// True if the elements are in the same dimension, false otherwise
        /// </summary>
        public bool IsDimensionMatching { get; }

        internal OnMarkerLeaveEventArgs(MtaElement markerLeft, dynamic matchingDimension)
        {
            Marker = ElementManager.Instance.GetElement<Marker>(markerLeft);
            IsDimensionMatching = (bool)matchingDimension;
        }
    }
}
