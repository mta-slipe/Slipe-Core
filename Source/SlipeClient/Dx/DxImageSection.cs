using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;
using Slipe.Shared;


namespace Slipe.Client.Dx
{
    /// <summary>
    /// Differing from DxImage, this clas only represnts a part of an image.
    /// </summary>
    public class DxImageSection : DxImage
    {
        /// <summary>
        /// The absolute top left coordinate of the section
        /// </summary>
        public Vector2 SectionTopLeft { get; set; }

        /// <summary>
        /// The dimensions of the section (width, height)
        /// </summary>
        public Vector2 SectionDimensions { get; set; }

        /// <summary>
        /// Create an image section from a filepath with color
        /// </summary>
        public DxImageSection(Vector2 position, Vector2 dimensions, Vector2 sectionUV, Vector2 UVDimensions, string filePath, float rotation, Vector2 rotationCenter, Color color, bool postGUI = false) : base(position, dimensions, filePath, rotation, rotationCenter, color, postGUI)
        {
            SectionTopLeft = sectionUV;
            SectionDimensions = UVDimensions;
        }

        /// <summary>
        /// Create an image section from a filepath with rotation
        /// </summary>
        public DxImageSection(Vector2 position, Vector2 dimensions, Vector2 sectionUV, Vector2 UVDimensions, string filePath, float rotation, Vector2 rotationCenter) : this(position, dimensions, sectionUV, UVDimensions, filePath, rotation, rotationCenter, Color.White) { }

        /// <summary>
        /// Create an image section from a filepath
        /// </summary>
        public DxImageSection(Vector2 position, Vector2 dimensions, Vector2 sectionUV, Vector2 UVDimensions, string filePath, float rotation = 0.0f) : this(position, dimensions, sectionUV, UVDimensions, filePath, rotation, Vector2.Zero) { }

        /// <summary>
        /// Create an image section from a material with color
        /// </summary>
        public DxImageSection(Vector2 position, Vector2 dimensions, Vector2 sectionUV, Vector2 UVDimensions, Material material, float rotation, Vector2 rotationCenter, Color color, bool postGUI = false) : base(position, dimensions, material, rotation, rotationCenter, color, postGUI)
        {
            SectionTopLeft = sectionUV;
            SectionDimensions = UVDimensions;
        }

        /// <summary>
        /// Create an image section from a material with rotation
        /// </summary>
        public DxImageSection(Vector2 position, Vector2 dimensions, Vector2 sectionUV, Vector2 UVDimensions, Material material, float rotation, Vector2 rotationCenter) : this(position, dimensions, sectionUV, UVDimensions, material, rotation, rotationCenter, Color.White) { }

        /// <summary>
        /// Create an image section from a material
        /// </summary>
        public DxImageSection(Vector2 position, Vector2 dimensions, Vector2 sectionUV, Vector2 UVDimensions, Material material, float rotation = 0.0f) : this(position, dimensions, sectionUV, UVDimensions, material, rotation, Vector2.Zero) { }

        public override bool Draw()
        {
            if (usePath)
                return MTAClient.DxDrawImageSection(Position.X, Position.Y, Dimensions.X, Dimensions.Y, SectionTopLeft.X, SectionTopLeft.Y, SectionDimensions.X, SectionDimensions.Y, FilePath, Rotation, RotationCenter.X, RotationCenter.Y, Color.Hex, PostGUI);
            else
                return MTAClient.DxDrawImageSection(Position.X, Position.Y, Dimensions.X, Dimensions.Y, SectionTopLeft.X, SectionTopLeft.Y, SectionDimensions.X, SectionDimensions.Y, Material?.MaterialElement, Rotation, RotationCenter.X, RotationCenter.Y, Color.Hex, PostGUI);
        }

    }
}
