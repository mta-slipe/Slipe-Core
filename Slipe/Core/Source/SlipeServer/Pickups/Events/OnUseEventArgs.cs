using SlipeLua.MtaDefinitions;
using SlipeLua.Server.Peds;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Pickups.Events
{
    public class OnUseEventArgs
    {
        /// <summary>
        /// The player that is using the pickup
        /// </summary>
        public Player Player { get; }

        internal OnUseEventArgs(MtaElement usingPlayer)
        {
            Player = ElementManager.Instance.GetElement<Player>(usingPlayer);
        }
    }
}
