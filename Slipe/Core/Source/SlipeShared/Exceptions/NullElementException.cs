using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Shared.Exceptions
{
    /// <summary>
    /// Exception raised when a wrapped MTA function cannot find a requested element
    /// </summary>
    public class NullElementException : System.Exception
    {
        public NullElementException(string message) : base (message) { }
    }
}
