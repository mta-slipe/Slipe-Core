﻿using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.IO;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SlipeLua.Client.IO.Events
{
    public class OnDoubleClickEventArgs
    {
        /// <summary>
        /// The mouse button that was pressed.
        /// </summary>
        public MouseButton MouseButton { get; }

        /// <summary>
        /// The element the player clicked on. This can be null.
        /// </summary>
        public PhysicalElement ClickedElement { get; }

        /// <summary>
        /// Position in the world the player clicked on.
        /// </summary>
        public Vector3 WorldPosition { get; }

        /// <summary>
        /// Position on the screen the player clicked on.
        /// </summary>
        public Vector2 ScreenPosition { get; }

        internal OnDoubleClickEventArgs(dynamic mouseButton, dynamic sx, dynamic sy, dynamic wx, dynamic wy, dynamic wz, MtaElement clickedElement)
        {
            MouseButton = (MouseButton)Enum.Parse(typeof(MouseButton), (string)mouseButton, true);
            ClickedElement = ElementManager.Instance.GetElement<PhysicalElement>(clickedElement);
            WorldPosition = new Vector3((float)wx, (float)wy, (float)wz);
            ScreenPosition = new Vector2((float)sx, (float)sy);
        }
    }
}
