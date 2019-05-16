using Slipe.Shared.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Gui.Events
{
    public class OnMouseWheelEventArgs
    {
        /// <summary>
        /// The state of the mouse wheel
        /// </summary>
        public MouseWheelState State { get; }

        internal OnMouseWheelEventArgs(dynamic state)
        {
            State = (MouseWheelState)state;
        }
    }
}
