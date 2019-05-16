using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Sounds.Events
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
