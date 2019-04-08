using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Numerics;
using Slipe.Shared.Utilities;

namespace Slipe.Client.Dx
{
    /// <summary>
    /// Represents a drawable rectangle
    /// </summary>
    public class Rectangle : Dx2DObject, IDrawable
    {
        /// <summary>
        /// The width and the height of this rectangle
        /// </summary>
        public Vector2 Dimensions { get; set; }

        /// <summary>
        /// A bool representing whether the rectangle can be positioned sub-pixel-ly.
        /// </summary>
        public bool SubPixelPositioning { get; set; }

        public Rectangle(Vector2 position, Vector2 dimensions, Color color, bool postGUI = false, bool subPixelPositioning = false)
        {
            Position = position;
            Dimensions = dimensions;
            Color = color;
            PostGUI = postGUI;
            SubPixelPositioning = subPixelPositioning;
        }

        /// <summary>
        /// Creates a white rectangle
        /// </summary>
        public Rectangle(Vector2 position, Vector2 dimensions) : this(position, dimensions, Color.White) { }

        /// <summary>
        /// Draw this rectangle
        /// </summary>
        public bool Draw()
        {
            return MtaClient.DxDrawRectangle(Position.X, Position.Y, Dimensions.X, Dimensions.Y, Color.Hex, PostGUI, SubPixelPositioning);
        }
    }
}
