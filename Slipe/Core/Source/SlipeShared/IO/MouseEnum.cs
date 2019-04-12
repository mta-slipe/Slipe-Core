using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.IO
{
    /// <summary>
    /// Represents different mouse buttons
    /// </summary>
    public enum MouseButton
    {
        Left,
        Middle,
        Right,
    }

    /// <summary>
    /// Represents different mouse button states
    /// </summary>
    public enum MouseButtonState
    {
        Up,
        Down
    }

    /// <summary>
    /// Represents the scroll direction of the mouse wheel
    /// </summary>
    public enum MouseWheelState
    {
        Down = -1,
        Up = 1
    }
}
