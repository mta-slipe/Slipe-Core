using Slipe.Client.Sounds;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Peds.Events
{
    public class OnRadioSwitchEventArgs
    {
        /// <summary>
        /// The station switched to
        /// </summary>
        public RadioStation RadioStation { get; }

        internal OnRadioSwitchEventArgs(dynamic station)
        {
            RadioStation = (RadioStation)station;
        }
    }
}
