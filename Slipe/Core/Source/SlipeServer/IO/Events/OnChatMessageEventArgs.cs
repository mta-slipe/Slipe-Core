using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.IO.Events
{
    public class OnChatMessageEventArgs
    {
        /// <summary>
        /// The text message that was broadcasted
        /// </summary>
        public string Message { get; }

        internal OnChatMessageEventArgs(dynamic message)
        {
            Message = (string) message;
        }
    }
}
