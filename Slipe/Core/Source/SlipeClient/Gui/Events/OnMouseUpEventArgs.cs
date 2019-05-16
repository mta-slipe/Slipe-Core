using Slipe.Shared.IO;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Slipe.Client.Gui.Events
{
    public class OnMouseUpEventArgs
    {
        /// <summary>
        /// The mouse button that was pressed.
        /// </summary>
        public MouseButton MouseButton { get; }

        /// <summary>
        /// Position on the screen the player clicked on.
        /// </summary>
        public Vector2 ScreenPosition { get; }

        internal OnMouseUpEventArgs(dynamic button, dynamic x, dynamic y)
        {
            MouseButton = (MouseButton)Enum.Parse(typeof(MouseButton), (string)button);
            ScreenPosition = new Vector2((float)x, (float)y);
        }
    }
}
