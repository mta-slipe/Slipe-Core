using Slipe.Shared.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnChatArgs
    {
        /// <summary>
        /// The message typed into the chat.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// The message type
        /// </summary>
        public MessageType MessageType { get; }

        internal OnChatArgs(string message, MessageType type)
        {
            Message = message;
            MessageType = type;
        }
    }
}
