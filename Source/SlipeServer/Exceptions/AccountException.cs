using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Exceptions
{
    public class AccountException : System.Exception
    {
        public AccountException(string message) : base(message) { }
    }
}
