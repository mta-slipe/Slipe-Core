using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using Slipe.Shared.IO;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnClickEventArgs
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

        internal OnClickEventArgs(dynamic mouseButton, dynamic buttonState, MtaElement clickedElement, dynamic wx, dynamic wy, dynamic wz, dynamic sx, dynamic sy)
        {
            MouseButton = (MouseButton)Enum.Parse(typeof(MouseButton), (string)mouseButton, true);
            MouseButtonState = (MouseButtonState)Enum.Parse(typeof(MouseButtonState), (string)buttonState, true);
            ClickedElement = ElementManager.Instance.GetElement<PhysicalElement>(clickedElement);
            WorldPosition = new Vector3((float) wx, (float) wy, (float) wz);
            ScreenPosition = new Vector2((float)sx, (float)sy);
        }
    }
}
