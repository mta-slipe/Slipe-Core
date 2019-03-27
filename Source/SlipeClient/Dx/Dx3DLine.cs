using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;
using Slipe.Shared;

namespace Slipe.Client.Dx
{
    public class Dx3DLine : IDrawable
    {
        protected PhysicalElement attachElement;
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
        /// The offset with which this line is attached to another element
        /// </summary>
        public Vector3 AttachOffset { get; set; }

        /// <summary>
        /// Bool indicating if the line rotates with the element it is attached to
        /// </summary>
        public bool RotateAlong { get; set; }

        /// <summary>
        /// Get the element to which this line is attached
        /// </summary>
        public PhysicalElement ElementAttachedTo
        {
            get
            {
                return attachElement;
            }
        }

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
        /// Draw this line
        /// </summary>
        public bool Draw()
        {
            return MTAClient.DxDrawLine3D(StartPosition.X, StartPosition.Y, StartPosition.Z, EndPosition.X, EndPosition.Y, EndPosition.Z, Color.Hex, Width, PostGUI);
        }

        /// <summary>
        /// Attach this line to a physical element
        /// </summary>
        public void AttachTo(PhysicalElement element, Vector3 offset)
        {
            attachElement = element;
            AttachOffset = offset;
            Client.Renderer.OnPreRender += Update;
        }

        /// <summary>
        /// Detach this line from any physical element
        /// </summary>
        public void Detach()
        {
            Client.Renderer.OnPreRender -= Update;
        }

        /// <summary>
        /// Attach to an element without an offset
        /// </summary>
        public void AttachTo(PhysicalElement element)
        {
            AttachTo(element, Vector3.Zero);
        }

        protected void Update()
        {
            StartPosition = attachElement.Position + AttachOffset;
            if(RotateAlong)
                EndPosition = Vector3.Transform(relativeEndPosition, attachElement.Matrix * Matrix4x4.CreateTranslation(AttachOffset));
            else
                EndPosition = StartPosition + relativeEndPosition;
        }
    }
}
