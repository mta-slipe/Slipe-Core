using SlipeLua.Shared.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Peds.Events
{
    public class OnChatEventArgs
    {
        /// <summary>
        /// The message typed into the chat.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// The message type
        /// </summary>
        public MessageType MessageType { get; }

        internal OnChatEventArgs(dynamic message, dynamic type)
        {
            Message = (string) message;
            MessageType = (MessageType) type;
        }
    }
}
