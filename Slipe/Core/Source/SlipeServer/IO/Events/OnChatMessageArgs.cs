using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.IO.Events
{
    public class OnChatMessageArgs
    {
        /// <summary>
        /// The text message that was broadcasted
        /// </summary>
        public string Message { get; }

        internal OnChatMessageArgs(string message)
        {
            Message = message;
        }
    }
}
