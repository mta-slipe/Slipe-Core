using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;

namespace SlipeLua.Server.Events
{
    /// <summary>
    /// Class that wraps event utility methods
    /// </summary>
    public static class Event
    {
        /// <summary>
        /// Cancel the current event
        /// </summary>
        public static void Cancel(string reason = "", bool cancel = true)
        {
            MtaServer.CancelEvent(cancel, reason);
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
