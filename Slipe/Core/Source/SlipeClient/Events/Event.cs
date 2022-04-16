using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;

namespace SlipeLua.Client.Events
{
    /// <summary>
    /// Class that wraps event utility methods
    /// </summary>
    public static class Event
    {
        /// <summary>
        /// Cancel the current event
        /// </summary>
        public static void Cancel()
        {
            MtaClient.CancelEvent();
        }

        /// <summary>
        /// Check if the current event was canceled
        /// </summary>
        public static bool WasCancelled
        {
            get
            {
                return MtaShared.WasEventCancelled();
            }            
        }
    }
}
