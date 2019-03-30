using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;
using Slipe.Shared;
using Slipe.Shared.Interfaces;

namespace Slipe.Client.Dx
{
    /// <summary>
    /// Draws a textured 3D line between two points in the 3D world - rendered for one frame
    /// </summary>
    public class Dx3DMaterialLineSection : Dx3DMaterialLine, IDrawable
    {
        /// <summary>
        /// The top left corner of the section
        /// </summary>
        Vector2 UV { get; set; }

        /// <summary>
        /// The absolute width and height of the section
        /// </summary>
        Vector2 UVDimensions { get; set; }

        /// <summary>
        /// Createa material 3d line from all arguments
        /// </summary>
        public Dx3DMaterialLineSection(Vector3 startPos, Vector3 endPos, Vector2 uv, Vector2 uvDimensions, Material material, float width, Color color, Vector3 faceToward, bool postGUI = false) : base(startPos, endPos, material, width, color, faceToward, postGUI)
        {
            UV = uv;
            UVDimensions = uvDimensions;
        }

        /// <summary>
        /// Create a material 3d line that always faces the camera
        /// </summary>
        public Dx3DMaterialLineSection(Vector3 startPos, Vector3 endPos, Vector2 uv, Vector2 uvDimensions, Material material, float width, Color color) : this(startPos, endPos, uv, uvDimensions, material, width, color, Vector3.Zero) { }

        /// <summary>
        /// Create a material 3d line with a base color of white
        /// </summary>
        public Dx3DMaterialLineSection(Vector3 startPos, Vector3 endPos, Vector2 uv, Vector2 uvDimensions, Material material, float width) : this(startPos, endPos, uv, uvDimensions, material, width, Color.White) { }

        /// <summary>
        /// Draw this line
        /// </summary>
        public override bool Draw()
        {
            if (FaceToward == Vector3.Zero)
                return MTAClient.DxDrawMaterialSectionLine3D(StartPosition.X, StartPosition.Y, StartPosition.Z, EndPosition.X, EndPosition.Y, EndPosition.Z, UV.X, UV.Y, UVDimensions.X, UVDimensions.Y, Material?.MaterialElement, Width, Color.Hex, PostGUI);
            else
                return MTAClient.DxDrawMaterialSectionLine3D(StartPosition.X, StartPosition.Y, StartPosition.Z, EndPosition.X, EndPosition.Y, EndPosition.Z, UV.X, UV.Y, UVDimensions.X, UVDimensions.Y, Material?.MaterialElement, Width, Color.Hex, PostGUI, FaceToward.X, FaceToward.Y, FaceToward.Z);
        }
    }
}
