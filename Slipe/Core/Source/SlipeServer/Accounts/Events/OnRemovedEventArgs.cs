using Slipe.MtaDefinitions;
using Slipe.Server.Peds;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Accounts.Events
{
    public class OnRemovedEventArgs
    {
        /// <summary>
        /// The ban that was removed
        /// </summary>
        public Ban Ban { get; }

        /// <summary>
        /// The player responsible for removing the ban or null
        /// </summary>
        public Player ResponsiblePlayer { get; }

        internal OnRemovedEventArgs(MtaBan ban, MtaElement player)
        {
            Ban = new Ban(ban);
            ResponsiblePlayer = ElementManager.Instance.GetElement<Player>(player);
        }
    }
}
