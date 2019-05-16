using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Sounds.Events
{
    public class OnStopEventArgs
    {
        public string Reason { get; }

        internal OnStopEventArgs(dynamic r)
        {
            Reason = (string)r;
        }
    }
}
