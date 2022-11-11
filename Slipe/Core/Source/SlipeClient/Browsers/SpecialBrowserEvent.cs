using SlipeLua.Client.Browsers.Events;
using SlipeLua.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Browsers
{
    public class SpecialBrowserEvent
    {
        public string EventName { get; }

        public Action<SpecialEventArgs> Action { get; set; }

        public SpecialBrowserEvent(string eventName)
        {
            EventName = eventName;
        }

        /// <summary>
        /// Check, if the event invokable.
        /// </summary>
        public bool IsInvokable(string eventName)
        {
            return eventName == EventName;
        }

        /// <summary>
        /// Invoke the event
        /// </summary>
        public void Invoke(string eventName, Browser browser, params object[] optionalParameters)
        {
            if(Action != null)
            {
                Action.Invoke(new SpecialEventArgs(browser, optionalParameters));
            }
        }
    }
}
