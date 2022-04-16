﻿using SlipeLua.Shared.IO;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SlipeLua.Client.Gui.Events
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

        internal OnMouseUpEventArgs(dynamic mouseButton, dynamic x, dynamic y)
        {
            MouseButton = (MouseButton)Enum.Parse(typeof(MouseButton), (string)mouseButton, true);
            ScreenPosition = new Vector2((float)x, (float)y);
        }
    }
}
