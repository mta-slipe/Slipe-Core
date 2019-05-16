using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Game.Events
{
    public class OnFileDownloadCompleteEventArgs
    {
        /// <summary>
        /// The path of the downloaded file
        /// </summary>
        public string Path { get; }

        /// <summary>
        /// True if the download was a succes
        /// </summary>
        public bool Success { get; }

        internal OnFileDownloadCompleteEventArgs(dynamic path, dynamic success)
        {
            Path = (string)path;
            Success = (bool)success;
        }
    }
}
