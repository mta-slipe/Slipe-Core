using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;

namespace Slipe.Server.Accounts
{
    /// <summary>
    /// Manages accounts
    /// </summary>
    public class AccountManager
    {
        private static AccountManager instance;
        private Dictionary<object, Account> accounts;

        /// <summary>
        /// Get the singleton instance of this class
        /// </summary>
        public static AccountManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountManager();
                return instance;
            }
        }

        protected AccountManager()
        {
            accounts = new Dictionary<object, Account>();
        }

        /// <summary>
        /// Registers an account class
        /// </summary>
        public void RegisterAccount(Account account)
        {
            accounts.Add(account.MTAAccount, account);
        }

        /// <summary>
        /// Gets an account class instance given a certain MTA account
        /// </summary>
        public Account GetAccount(MtaAccount account)
        {
            if (account == null)
            {
                return null;
            }
            if (!accounts.ContainsKey(account))
            {
                return new Account(account);
            }
            return accounts[account];
        }

        /// <summary>
        /// Cast an array of MTAElements to a desired type
        /// </summary>
        public Account[] CastMultiple(MtaAccount[] accounts)
        {
            Account[] result = new Account[accounts.Length];
            for (int i = 0; i < accounts.Length; i++)
            {
                result[i] = (Account) Instance.GetAccount(accounts[i]);
            }
            return result;
        }
    }
}
