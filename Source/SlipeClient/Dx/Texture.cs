using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Client.Enums;
using Slipe.MTADefinitions;
using System.Numerics;
using Slipe.Shared;

namespace Slipe.Client.Dx
{
    /// <summary>
    /// Drawable texture
    /// </summary>
    public class Texture : Material
    {
        protected Texture() { }

        /// <summary>
        /// Create a texture element from a file or raw image string
        /// </summary>
        public Texture(string filePathOrPixels, TextureFormat textureFormat = TextureFormat.argb, bool mipmaps = true, TextureEdge textureEdge = TextureEdge.wrap)
        {
            materialElement = MTAClient.DxCreateTexture(filePathOrPixels, textureFormat.ToString(), mipmaps, textureEdge.ToString());
        }

        /// <summary>
        /// Create an empty texture
        /// </summary>
        public Texture(Vector2 dimensions, TextureFormat textureFormat = TextureFormat.argb, TextureEdge textureEdge = TextureEdge.wrap, TextureType textureType = TextureType.TwoDimensional, int depth = 1)
        {
            string textureTypeString = "cube";
            if (textureType == TextureType.TwoDimensional)
                textureTypeString = "2d";
            else if (textureType == TextureType.ThreeDimensional)
                textureTypeString = "3d";

            materialElement = MTAClient.DxCreateTexture((int)dimensions.X, (int)dimensions.Y, textureFormat.ToString(), textureEdge.ToString(), textureTypeString, depth);
        }

        /// <summary>
        /// Get the pixels of a section of this texture
        /// </summary>
        public TexturePixels GetPixels(Vector2 topLeft, Vector2 dimensions, int surfaceIndex = 0)
        {
            return new TexturePixels(MTAClient.DxGetTexturePixels(surfaceIndex, materialElement, (int) topLeft.X, (int)topLeft.Y, (int)dimensions.X, (int)dimensions.Y));
        }

        /// <summary>
        /// Get all pixels of this texture
        /// </summary>
        public TexturePixels GetPixels(int surfaceIndex = 0)
        {
            return GetPixels(Vector2.Zero, Vector2.Zero, surfaceIndex);
        }

        /// <summary>
        /// This functions allows you to change the edge handling after creating the texture.
        /// </summary>
        public bool SetEdge(TextureEdge edge, Color borderColor)
        {
            return MTAClient.DxSetTextureEdge(materialElement, edge == TextureEdge.mirror_once ? "mirror-once" : edge.ToString(), borderColor.Hex);
        }

        /// <summary>
        /// Change edge handling with white border if border is selected
        /// </summary>
        public bool SetEdge(TextureEdge edge)
        {
            return SetEdge(edge, Color.White);
        }

        /// <summary>
        /// This function sets the pixels of a texture element. It can be used with a standard texture, render target or screen source.
        /// </summary>
        public bool SetPixels(TexturePixels pixels, Vector2 topLeft, Vector2 dimensions, int surfaceIndex = 0)
        {
            string p = pixels.Convert(ImageFormat.plain);
            return MTAClient.DxSetTexturePixels(surfaceIndex, materialElement, p, (int) topLeft.X, (int)topLeft.Y, (int)dimensions.X, (int)dimensions.Y);
        }
    }
}
