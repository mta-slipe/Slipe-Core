using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Browsers.Events
{
    public class OnPopupEventArgs
    {
        /// <summary>
        /// The target url
        /// </summary>
        public string Url { get; }

        public string Opener { get; }

        public bool IsPopup { get; }

        internal OnPopupEventArgs(dynamic target, dynamic opener, bool isPopup)
        {
            Url = (string)target;
            Opener = (string)opener;
            IsPopup = (bool)isPopup;
        }
    }
}
