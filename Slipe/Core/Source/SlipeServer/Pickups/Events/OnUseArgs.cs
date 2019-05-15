using Slipe.Server.Peds;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Pickups.Events
{
    public class OnUseArgs
    {
        /// <summary>
        /// The player that is using the pickup
        /// </summary>
        public Player Player { get; }

        internal OnUseArgs(Player usingPlayer)
        {
            Player = usingPlayer;
        }
    }
}
