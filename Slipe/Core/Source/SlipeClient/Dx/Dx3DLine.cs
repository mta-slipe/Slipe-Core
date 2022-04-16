using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Utilities;
using SlipeLua.Client.Helpers;
using SlipeLua.Client.Elements;
using SlipeLua.Client.Game.Events;
using SlipeLua.Client.Rendering.Events;

namespace SlipeLua.Client.Dx
{
    public class Dx3DLine : LazyAttachableObject, IDrawable
    {
        protected Vector3 relativeEndPosition;

        /// <summary>
        /// The start position of the 3D line
        /// </summary>
        protected Vector3 startPos;
        public Vector3 StartPosition
        {
            get
            {
                Update();
                return startPos;
            }
            set
            {
                startPos = value;
            }
        }

        /// <summary>
        /// The end position of the 3D line
        /// </summary>
        protected Vector3 endPos;
        public Vector3 EndPosition
        {
            get
            {
                Update();
                return endPos;
            }
            set
            {
                endPos = value;
            }
        }

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
        /// Get and set if this line is currently visible
        /// </summary>
        public bool Visible { get; set; }

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
        public Dx3DLine(PhysicalElement attachedTo, Vector3 relativeEndPos, Matrix4x4 offset) : this(Vector3.Zero, relativeEndPos)
        {
            AttachTo(attachedTo, offset);
        }

        /// <summary>
        /// Draw this line
        /// </summary>
        public virtual bool Draw(RootElement source, OnRenderEventArgs eventArgs)
        {
            if(Visible)
                return MtaClient.DxDrawLine3D(StartPosition.X, StartPosition.Y, StartPosition.Z, EndPosition.X, EndPosition.Y, EndPosition.Z, Color.Hex, Width, PostGUI);
            return false;
        }

        protected override void Update(RootElement source = null, OnUpdateEventArgs eventArgs = null)
        {
            if(IsAttached)
            {
                startPos = ToAttached.Position + Offset.Translation;
                endPos = Vector3.Transform(relativeEndPosition, ToAttached.Matrix * Offset);
            }
        }
    }
}
