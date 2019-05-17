using Slipe.MtaDefinitions;
using Slipe.Shared.IO;
using Slipe.Shared.Peds;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Slipe.Shared.Elements.Events
{
    public class OnClickedEventArgs
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

        internal OnClickedEventArgs(dynamic mouseButton, dynamic buttonState, MtaElement clickedBy, dynamic x, dynamic y, dynamic z)
        {
            MouseButton = (MouseButton) Enum.Parse(typeof(MouseButton), (string)mouseButton, true);
            MouseButtonState = (MouseButtonState)Enum.Parse(typeof(MouseButtonState), (string)buttonState, true);
            Player = ElementManager.Instance.GetElement<SharedPed>(clickedBy);
            Position = new Vector3((float)x, (float)y, (float)z);
        }
    }
}
