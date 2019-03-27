using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared;
using System.Numerics;

namespace Slipe.Client.Dx
{
    /// <summary>
    /// Class representing drawable objects
    /// </summary>
    public abstract class Dx2DObject
    {
        /// <summary>
        /// The color that is used to draw this object
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// The start or center position of the object
        /// </summary>
        public Vector2 Position { get; set; }

        /// <summary>
        /// Boolean indicating whether this object is drawn before or after GUI's are drawn
        /// </summary>
        public bool PostGUI { get; set; }
    }
}
