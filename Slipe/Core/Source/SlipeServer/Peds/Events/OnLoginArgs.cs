using Slipe.Server.Accounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnLoginArgs
    {
        /// <summary>
        /// The previous account the player was signed in with
        /// </summary>
        public Account PreviousACcount { get; }

        /// <summary>
        /// The new account the player has signed in to
        /// </summary>
        public Account NewAccount { get; }

        internal OnLoginArgs(Account previousAccount, Account newAccount)
        {
            PreviousACcount = previousAccount;
            NewAccount = newAccount;
        }
    }
}
