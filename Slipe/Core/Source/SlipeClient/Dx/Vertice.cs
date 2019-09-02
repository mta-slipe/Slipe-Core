using Slipe.Shared.Utilities;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Slipe.Client.Dx
{
    /// <summary>
    /// Represents a vertice drawn in primitives
    /// </summary>
    public struct Vertice
    {
        /// <summary>
        /// The position of the vertice
        /// </summary>
        public Vector2 Position { get; }

        /// <summary>
        /// The color of the vertice
        /// </summary>
        public Color Color { get; }

        /// <summary>
        /// If using material primitives, this describes the relative top left coordinate of the image
        /// </summary>
        public Vector2 TopLeft { get; }

        public Vertice(Vector2 position, Color color)
        {
            Position = position;
            Color = color;
            TopLeft = Vector2.Zero;
        }

        public Vertice(Vector2 position, Color color, Vector2 topLeft)
        {
            Position = position;
            Color = color;
            TopLeft = topLeft;
        }
    }
}
