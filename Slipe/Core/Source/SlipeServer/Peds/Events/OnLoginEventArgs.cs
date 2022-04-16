using SlipeLua.MtaDefinitions;
using SlipeLua.Server.Accounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Peds.Events
{
    public class OnLoginEventArgs
    {
        /// <summary>
        /// The previous account the player was signed in with
        /// </summary>
        public Account PreviousAccount { get; }

        /// <summary>
        /// The new account the player has signed in to
        /// </summary>
        public Account NewAccount { get; }

        internal OnLoginEventArgs(MtaAccount previousAccount, MtaAccount newAccount)
        {
            PreviousAccount = Account.Get(previousAccount);
            NewAccount = Account.Get(newAccount);
        }
    }
}
