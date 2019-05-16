using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MtaDefinitions;
using Slipe.Shared.Utilities;
using Slipe.Client.Elements;
using Slipe.Client.Rendering.Events;

namespace Slipe.Client.Dx
{
    public class Dx3DMaterialLine : Dx3DLine, IDrawable
    {
        /// <summary>
        /// The position the front of the line should face towards. If this is not set, the camera position is used, so the front of the line faces toward the camera.
        /// </summary>
        public Vector3 FaceToward { get; set; }

        /// <summary>
        /// A material to draw the line with.
        /// </summary>
        public Material Material { get; set; }

        /// <summary>
        /// Create a material line from all the parameters
        /// </summary>
        public Dx3DMaterialLine(Vector3 startPos, Vector3 endPos, Material material, float width, Color color, Vector3 faceToward, bool postGUI = false) : base(startPos, endPos, color, width, postGUI)
        {
            Material = material;
            FaceToward = faceToward;
        }

        /// <summary>
        /// Create a material line that always faces the camera
        /// </summary>
        public Dx3DMaterialLine(Vector3 startPos, Vector3 endPos, Material material, float width, Color color) : this(startPos, endPos, material, width, color, Vector3.Zero) { }

        /// <summary>
        /// Create a material line with white as the base color
        /// </summary>
        public Dx3DMaterialLine(Vector3 startPos, Vector3 endPos, Material material, float width) : this(startPos, endPos, material, width, Color.White) { }

        /// <summary>
        /// Draw this material line
        /// </summary>
        public override bool Draw(RootElement source, OnRenderEventArgs eventArgs)
        {
            if (FaceToward == Vector3.Zero)
                return MtaClient.DxDrawMaterialLine3D(StartPosition.X, StartPosition.Y, StartPosition.Z, EndPosition.X, EndPosition.Y, EndPosition.Z, Material?.MaterialElement, Width, Color.Hex, PostGUI);
            else
                return MtaClient.DxDrawMaterialLine3D(StartPosition.X, StartPosition.Y, StartPosition.Z, EndPosition.X, EndPosition.Y, EndPosition.Z, Material?.MaterialElement, Width, Color.Hex, PostGUI, FaceToward.X, FaceToward.Y, FaceToward.Z);
        }
    }
}
