using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Accounts.Events
{
    public class OnDataChangeEventArgs
    {
        /// <summary>
        /// The account that had data changed
        /// </summary>
        public Account Account { get; }

        /// <summary>
        /// The changed key
        /// </summary>
        public string Key { get; }

        /// <summary>
        /// The new value
        /// </summary>
        public string Value { get; }

        internal OnDataChangeEventArgs(MtaAccount account, dynamic key, dynamic value)
        {
            Account = Account.Get(account);
            Key = (string) key;
            Value = (string) value;
        }
    }
}
