using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Game.Events
{
    public class OnSettingChangeArgs
    {
        /// <summary>
        /// The name of the setting that changed
        /// </summary>
        public string Setting { get; }

        /// <summary>
        /// The old value of this setting
        /// </summary>
        public string OldValue { get; }

        /// <summary>
        /// The new value of this setting
        /// </summary>
        public string NewValue { get; }

        internal OnSettingChangeArgs(string setting, string oldValue, string newValue)
        {
            Setting = setting;
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}
