using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Sounds.Events
{
    public class OnDownloadFinishedEventArgs
    {
        public int Length { get; }

        internal OnDownloadFinishedEventArgs(dynamic l)
        {
            Length = (int)l;
        }
    }
}
