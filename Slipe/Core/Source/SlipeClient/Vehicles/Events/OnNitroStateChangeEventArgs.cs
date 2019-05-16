using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Vehicles.Events
{
    public class OnNitroStateChangeEventArgs
    {
        /// <summary>
        /// True if nitro was activated, false otherwise
        /// </summary>
        public bool State { get; }

        internal OnNitroStateChangeEventArgs(dynamic b)
        {
            State = (bool)b;
        }
    }
}
