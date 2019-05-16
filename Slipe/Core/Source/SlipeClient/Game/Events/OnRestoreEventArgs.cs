using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Game.Events
{
    public class OnRestoreEventArgs
    {
        /// <summary>
        /// True if the rendertargets are cleared
        /// </summary>
        public bool RenderTargetsCleared { get; }

        internal OnRestoreEventArgs(dynamic cleared)
        {
            RenderTargetsCleared = (bool)cleared;
        }
    }
}
