using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Sounds.Events
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
