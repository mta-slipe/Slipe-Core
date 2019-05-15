using Slipe.Server.Accounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnLogoutArgs
    {
        /// <summary>
        /// The previous account the player was signed in with
        /// </summary>
        public Account PreviousAccount { get; }

        /// <summary>
        /// The new account the player has signed in to
        /// </summary>
        public Account NewAccount { get; }

        internal OnLogoutArgs(Account previousAccount, Account newAccount)
        {
            PreviousAccount = previousAccount;
            NewAccount = newAccount;
        }
    }
}
