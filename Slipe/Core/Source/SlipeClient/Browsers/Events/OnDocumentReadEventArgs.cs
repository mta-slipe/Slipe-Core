using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Browsers.Events
{
    public class OnDocumentReadEventArgs
    {
        /// <summary>
        /// The url that was loaded
        /// </summary>
        public string Url { get; }

        internal OnDocumentReadEventArgs(dynamic url)
        {
            Url = (string) url;
        }
    }
}
