using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Browsers.Events
{
    public class OnLoadFailEventArgs
    {
        /// <summary>
        /// The url that was loaded
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// The error code that was thrown
        /// </summary>
        public int ErrorCode { get; }

        /// <summary>
        /// The descriptino of the error
        /// </summary>
        public string Description { get; }

        internal OnLoadFailEventArgs(dynamic url, dynamic errorCode, dynamic errorDescription)
        {
            Url = (string) url;
            ErrorCode = (int) errorCode;
            Description = (string) errorDescription;
        }
    }
}
