using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.IO.Events
{
    public class OnKeyEventArgs
    {
        /// <summary>
        /// The string representation of the key
        /// </summary>
        public string Key { get; }

        /// <summary>
        /// True if the key was pressed
        /// </summary>
        public bool IsPressed { get; }

        internal OnKeyEventArgs(dynamic key, dynamic isPressed)
        {
            Key = (string)key;
            IsPressed = (bool)isPressed;
        }
    }
}
