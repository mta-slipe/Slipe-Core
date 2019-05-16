using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Game.Events
{
    public class OnSettingChangeEventArgs
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

        internal OnSettingChangeEventArgs(dynamic setting, dynamic oldValue, dynamic newValue)
        {
            Setting = (string) setting;
            OldValue = (string) oldValue;
            NewValue = (string) newValue;
        }
    }
}
