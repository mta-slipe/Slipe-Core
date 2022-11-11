using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Browsers.Events
{
    public class SpecialEventArgs : EventArgs
    {
        public Browser Browser { get; }
        public object[] optionalParameters { get; }
        public SpecialEventArgs(Browser browser, object[] optionalParameters)
        {
            Browser = browser;
            this.optionalParameters = optionalParameters;
        }
    }
}
