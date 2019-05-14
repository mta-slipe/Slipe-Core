using Slipe.Shared.IO;
using Slipe.Shared.Peds;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Slipe.Shared.Elements.Events
{
    public class OnClickedArgs
    {
        /// <summary>
        /// The mouse button that was clicked with
        /// </summary>
        public MouseButton MouseButton { get; }

        /// <summary>
        /// Whether it was an up or a down click
        /// </summary>
        public MouseButtonState MouseButtonState { get; }

        /// <summary>
        /// The player that clicked on the element
        /// </summary>
        public SharedPed Player { get; }

        /// <summary>
        /// Get the 3D position of the click
        /// </summary>
        public Vector3 Position { get; }

        internal OnClickedArgs(MouseButton mouseButton, MouseButtonState buttonState, SharedPed clickedBy, Vector3 clickPosition)
        {
            MouseButton = mouseButton;
            MouseButtonState = buttonState;
            Player = clickedBy;
            Position = clickPosition;
        }
    }
}
