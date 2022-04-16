using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Browsers.Events
{
    public class OnResourceBlockedEventArgs
    {
        /// <summary>
        /// The url that was blocked
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// The domain
        /// </summary>
        public string Domain { get; }

        /// <summary>
        /// The reason why the resource was blocked
        /// </summary>
        public BlockReason Reason { get; }

        internal OnResourceBlockedEventArgs(dynamic url, dynamic domain, dynamic reason)
        {
            Url = (string)url;
            Domain = (string)domain;
            Reason = (BlockReason)reason;
        }
    }
}
