using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Peds.Events
{
    public class OnConsoleEventArgs
    {
        /// <summary>
        /// Message entered into the console.
        /// </summary>
        public string Message { get; }

        internal OnConsoleEventArgs(dynamic message)
        {
            Message = (string) message;
        }
    }
}
