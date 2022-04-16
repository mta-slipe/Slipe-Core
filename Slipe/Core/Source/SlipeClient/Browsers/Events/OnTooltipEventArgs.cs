using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Browsers.Events
{
    public class OnTooltipEventArgs
    {
        /// <summary>
        /// The tooltip message
        /// </summary>
        public string Tooltip { get; }
        internal OnTooltipEventArgs(dynamic tooltip)
        {
            Tooltip = (string)tooltip;
        }
    }
}
