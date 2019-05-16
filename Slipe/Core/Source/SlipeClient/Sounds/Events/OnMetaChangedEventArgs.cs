using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Sounds.Events
{
    public class OnMetaChangedEventArgs
    {
        /// <summary>
        /// The title of the stream
        /// </summary>
        public string StreamTitle { get; }

        internal OnMetaChangedEventArgs(dynamic t)
        {
            StreamTitle = (string)t;
        }
    }
}
