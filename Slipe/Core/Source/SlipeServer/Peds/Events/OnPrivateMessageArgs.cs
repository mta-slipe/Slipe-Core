using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnPrivateMessageArgs
    {
        /// <summary>
        /// The message that was sent
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// The player receiving the PM
        /// </summary>
        public Player Recipient { get; }

        internal OnPrivateMessageArgs(string message, Player recipient)
        {
            Message = message;
            Recipient = recipient;
        }
    }
}
