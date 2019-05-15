using Slipe.Shared.Elements;
using Slipe.Shared.IO;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnClickArgs
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

        internal OnClickArgs(MouseButton mouseButton, MouseButtonState buttonState, PhysicalElement clickedElement, Vector3 worldPosition, Vector2 screenPosition)
        {
            MouseButton = mouseButton;
            MouseButtonState = buttonState;
            ClickedElement = clickedElement;
            WorldPosition = worldPosition;
            ScreenPosition = screenPosition;
        }
    }
}
