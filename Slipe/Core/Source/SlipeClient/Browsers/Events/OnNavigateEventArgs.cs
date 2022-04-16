using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Browsers.Events
{
    public class OnNavigateEventArgs
    {
        /// <summary>
        /// The target
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// If the browser was created with isLocal set to true, and the browser tried to load a remote page, this would be set to true (and vice-versa).
        /// </summary>
        public bool IsBlocked { get; }
        internal OnNavigateEventArgs(dynamic target, dynamic isBlocked)
        {
            Url = (string)target;
            IsBlocked = (bool)isBlocked;
        }
    }
}
