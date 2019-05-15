using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnConsoleArgs
    {
        /// <summary>
        /// Message entered into the console.
        /// </summary>
        public string Message { get; }

        internal OnConsoleArgs(string message)
        {
            Message = message;
        }
    }
}
