using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Peds;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Shared.Pickups.Events
{
    public class OnHitArgs
    {
        /// <summary>
        /// The player that hit this pickup
        /// </summary>
        public SharedPed Player { get; }

        /// <summary>
        /// True if the dimensions of the two elements are matching, false otherwise
        /// </summary>
        public bool IsDimensionMatching { get; }

        internal OnHitArgs(MtaElement hitPlayer, dynamic matchingDimension)
        {
            Player = ElementManager.Instance.GetElement<SharedPed>(hitPlayer);
            IsDimensionMatching = (bool) matchingDimension;
        }
    }
}
