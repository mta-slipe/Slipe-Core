using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
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
