using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Accounts.Events
{
    public class OnDataChangeArgs
    {
        /// <summary>
        /// The changed key
        /// </summary>
        public string Key { get; }

        /// <summary>
        /// The new value
        /// </summary>
        public string Value { get; }

        internal OnDataChangeArgs(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
