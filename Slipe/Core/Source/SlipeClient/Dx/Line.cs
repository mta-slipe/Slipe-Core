using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Numerics;
using Slipe.Shared.Utilities;
using Slipe.Client.Elements;
using Slipe.Client.Rendering.Events;

namespace Slipe.Client.Dx
{
    /// <summary>
    /// return MTAClient.DxDrawLine((int)start.X, (int)start.Y, (int)end.X, (int)end.Y, color.Hex, width, postGui);
    /// </summary>
    public class Line : Dx2DObject, IDrawable
    {
        /// <summary>
        /// Position of the end of the line
        /// </summary>
        public Vector2 End { get; set; }

        /// <summary>
        /// Width of the line
        /// </summary>
        public float Width { get; set; }

        /// <summary>
        /// Create a line instance
        /// </summary>
        public Line(Vector2 start, Vector2 end, Color color, float width = 1.0f, bool postGUI = false)
        {
            Position = start;
            End = end;
            Color = color;
            Width = width;
            PostGUI = postGUI;
        }

        /// <summary>
        /// Draw the line
        /// </summary>
        public bool Draw(RootElement source, OnRenderEventArgs eventArgs)
        {
            return MtaClient.DxDrawLine((int)Position.X, (int)Position.Y, (int) End.X, (int) End.Y, Color.Hex, Width, PostGUI);
        }
    }
}
