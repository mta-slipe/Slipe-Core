using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Numerics;
using Slipe.Shared.Utilities;

namespace Slipe.Client.Dx
{
    /// <summary>
    /// Represents a drawable circle
    /// </summary>
    public class Circle : Dx2DObject, IDrawable
    {
        /// <summary>
        /// The radius of this circle
        /// </summary>
        public float Radius { get; set; }

        /// <summary>
        /// The color that the center of this circle has
        /// </summary>
        public Color CenterColor { get; set; }

        /// <summary>
        /// Representing the angle of the first point of the circle.
        /// </summary>
        float StartAngle { get; set; }

        /// <summary>
        /// Representing the angle of the last point of the circle.
        /// </summary>
        float StopAngle { get; set; }

        /// <summary>
        /// An integer ranging from 3-1024 representing how many triangles are used to form the circle, more segments = smoother circle. Note: using lots of segments may cause lag.
        /// </summary>
        int Segments { get; set; }

        /// <summary>
        /// Ratio between width and height, e.g: 2 would mean that the width of the circle is 2 times the height.
        /// </summary>
        int Ratio { get; set; }

        /// <summary>
        /// Create a circle
        /// </summary>
        public Circle(Vector2 position, float radius, Color color, Color centerColor, float startAngle = 0.0f, float stopAngle = 360.0f, int segments = 32, int ratio = 1, bool postGUI = false)
        {
            Position = position;
            Radius = radius;
            Color = color;
            CenterColor = centerColor;
            StartAngle = startAngle;
            StopAngle = stopAngle;
            Segments = segments;
            Ratio = ratio;
            PostGUI = postGUI;
        }

        /// <summary>
        /// Creates a circle where the centercolor is the same as the outer color
        /// </summary>
        public Circle(Vector2 position, float radius, Color color) : this(position, radius, color, color) { }

        /// <summary>
        /// Creates a white circle
        /// </summary>
        public Circle(Vector2 position, float radius) : this(position, radius, Color.White) { }

        /// <summary>
        /// Draw this circle
        /// </summary>
        public bool Draw()
        {
            return MtaClient.DxDrawCircle(Position.X, Position.Y, Radius, StartAngle, StopAngle, Color.Hex, CenterColor.Hex, Segments, Ratio, PostGUI);
        }
    }
}
