using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Browsers.Events
{
    public class OnLoadStartEventArgs
    {
        /// <summary>
        /// The url that is being loaded
        /// </summary>
        public string Url { get; }

        internal OnLoadStartEventArgs(dynamic url)
        {
            Url = (string)url;
        }
    }
}
