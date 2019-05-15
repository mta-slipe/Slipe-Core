using Slipe.Server.Accounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnBannedArgs
    {
        /// <summary>
        /// The ban that was added
        /// </summary>
        public Ban Ban { get; }

        /// <summary>
        /// The player who added the ban
        /// </summary>
        public Player ResponsiblePlayer { get; }

        internal OnBannedArgs(Ban ban, Player responsibleBanner)
        {
            Ban = ban;
            ResponsiblePlayer = responsibleBanner;
        }
    }
}
