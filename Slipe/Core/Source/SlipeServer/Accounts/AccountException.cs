using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Accounts
{
    public class AccountException : Exception
    {
        public AccountException(string message) : base(message) { }
    }
}
