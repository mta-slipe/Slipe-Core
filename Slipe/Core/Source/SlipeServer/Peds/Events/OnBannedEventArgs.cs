using SlipeLua.MtaDefinitions;
using SlipeLua.Server.Accounts;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Peds.Events
{
    public class OnBannedEventArgs
    {
        /// <summary>
        /// The ban that was added
        /// </summary>
        public Ban Ban { get; }

        /// <summary>
        /// The player who added the ban
        /// </summary>
        public Player ResponsiblePlayer { get; }

        internal OnBannedEventArgs(MtaBan ban, MtaElement responsibleBanner)
        {
            Ban = new Ban(ban);
            ResponsiblePlayer = ElementManager.Instance.GetElement<Player>(responsibleBanner);
        }
    }
}
