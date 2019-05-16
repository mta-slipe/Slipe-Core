using Slipe.MtaDefinitions;
using Slipe.Server.Accounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnLogoutEventArgs
    {
        /// <summary>
        /// The previous account the player was signed in with
        /// </summary>
        public Account PreviousAccount { get; }

        /// <summary>
        /// The new account the player has signed in to
        /// </summary>
        public Account NewAccount { get; }

        internal OnLogoutEventArgs(MtaAccount previousAccount, MtaAccount newAccount)
        {
            PreviousAccount = Account.Get(previousAccount);
            NewAccount = Account.Get(newAccount);
        }
    }
}
