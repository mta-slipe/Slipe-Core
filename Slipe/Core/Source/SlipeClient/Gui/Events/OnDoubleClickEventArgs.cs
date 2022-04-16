using SlipeLua.Shared.IO;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SlipeLua.Client.Gui.Events
{
    public class OnDoubleClickEventArgs
    {
        /// <summary>
        /// The mouse button that was pressed.
        /// </summary>
        public MouseButton MouseButton { get; }

        /// <summary>
        /// The button state.
        /// </summary>
        public MouseButtonState MouseButtonState { get; }

        /// <summary>
        /// Position on the screen the player clicked on.
        /// </summary>
        public Vector2 ScreenPosition { get; }

        internal OnDoubleClickEventArgs(dynamic mouseButton, dynamic buttonState, dynamic x, dynamic y)
        {
            MouseButton = (MouseButton)Enum.Parse(typeof(MouseButton), (string)mouseButton, true);
            MouseButtonState = (MouseButtonState)Enum.Parse(typeof(MouseButtonState), (string)buttonState, true);
            ScreenPosition = new Vector2((float)x, (float)y);
        }
    }
}
