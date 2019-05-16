using Slipe.MtaDefinitions;
using Slipe.Server.Peds;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Pickups.Events
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
