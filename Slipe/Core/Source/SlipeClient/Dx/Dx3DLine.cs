using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;
using Slipe.Shared;
using Slipe.Shared.Interfaces;

namespace Slipe.Client.Dx
{
    public class Dx3DLine : PreRenderAttachObject, IDrawable
    {
        protected Vector3 relativeEndPosition;

        /// <summary>
        /// The start position of the 3D line
        /// </summary>
        public Vector3 StartPosition { get; set; }

        /// <summary>
        /// The end position of the 3D line
        /// </summary>
        public Vector3 EndPosition { get; set; }

        /// <summary>
        /// The color of the 3D line
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// The width of the 3D line
        /// </summary>
        public float Width { get; set; }

        /// <summary>
        /// Wether to draw the line behind or in front of GUI elements
        /// </summary>
        public bool PostGUI { get; set; }

        /// <summary>
        /// Create a new 3D line
        /// </summary>
        public Dx3DLine(Vector3 startPos, Vector3 endPos, Color color, float width = 1.0f, bool postGUI = false)
        {
            StartPosition = startPos;
            EndPosition = endPos;
            relativeEndPosition = endPos - startPos;
            Color = color;
            Width = width;
            PostGUI = postGUI;
        }

        /// <summary>
        /// Create a red line
        /// </summary>
        public Dx3DLine(Vector3 startPos, Vector3 endPos) : this(startPos, endPos, Color.Red) { }

        /// <summary>
        /// Create a 3D line attached to a certain object
        /// </summary>
        public Dx3DLine(IToAttachable attachedTo, Vector3 relativeEndPos, Matrix4x4 offset) : this(Vector3.Zero, relativeEndPos)
        {
            AttachTo(attachedTo, offset);
        }

        /// <summary>
        /// Draw this line
        /// </summary>
        public virtual bool Draw()
        {
            return MTAClient.DxDrawLine3D(StartPosition.X, StartPosition.Y, StartPosition.Z, EndPosition.X, EndPosition.Y, EndPosition.Z, Color.Hex, Width, PostGUI);
        }

        protected override void Update()
        {
            StartPosition = ToAttached.Position + Offset.Translation;
            EndPosition = Vector3.Transform(relativeEndPosition, ToAttached.Matrix * Offset);
        }
    }
}
