using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Sounds.Events
{
    public class OnStartEventArgs
    {
        public string Reason { get; }

        internal OnStartEventArgs(dynamic r)
        {
            Reason = (string)r;
        }
    }
}
