using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Browsers.Events
{
    public class OnInputFocusChangeEventArgs
    {
        /// <summary>
        /// True if the focus was received, false otherwise
        /// </summary>
        public bool DidGainFocus { get; }

        internal OnInputFocusChangeEventArgs(dynamic gainedFocus)
        {
            DidGainFocus = (bool) gainedFocus;
        }
    }
}
