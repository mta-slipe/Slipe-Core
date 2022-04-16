using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Peds.Events
{
    public class OnPrivateMessageEventArgs
    {
        /// <summary>
        /// The message that was sent
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// The player receiving the PM
        /// </summary>
        public Player Recipient { get; }

        internal OnPrivateMessageEventArgs(dynamic message, MtaElement recipient)
        {
            Message = (string) message;
            Recipient = ElementManager.Instance.GetElement<Player>(recipient);
        }
    }
}
