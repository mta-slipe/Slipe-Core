using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Slipe.Client.Gui.Events
{
    public class OnMouseMoveEventArgs
    {
        /// <summary>
        /// The 2D position of the mouse
        /// </summary>
        public Vector2 Position { get; }

        internal OnMouseMoveEventArgs(dynamic x, dynamic y)
        {
            Position = new Vector2((float)x, (float)y);
        }
    }
}
