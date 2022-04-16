using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SlipeLua.Client.IO.Events
{
    public class OnMoveEventArgs
    {
        /// <summary>
        /// The position moved relatively from the previous position
        /// </summary>
        public Vector2 RelativePosition { get; }

        /// <summary>
        /// The new absolute screen position
        /// </summary>
        public Vector2 AbsolutePosition { get; }

        /// <summary>
        /// The new world position
        /// </summary>
        public Vector3 WorldPosition { get; }

        internal OnMoveEventArgs(dynamic rx, dynamic ry, dynamic ax, dynamic ay, dynamic wx, dynamic wy, dynamic wz)
        {
            RelativePosition = new Vector2((float)rx, (float)ry);
            AbsolutePosition = new Vector2((float)ax, (float)ay);
            WorldPosition = new Vector3((float)wx, (float)wy, (float) wz);
        }
    }
}
