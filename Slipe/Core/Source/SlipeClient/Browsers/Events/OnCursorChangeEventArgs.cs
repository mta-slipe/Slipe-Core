using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Browsers.Events
{
    public class OnCursorChangeEventArgs
    {
        /// <summary>
        /// Cursor ID, check https://wiki.multitheftauto.com/wiki/OnClientBrowserCursorChange
        /// </summary>
        public int CursorId { get; }

        internal OnCursorChangeEventArgs(dynamic cursorId)
        {
            CursorId = (int) cursorId;
        }
    }
}
