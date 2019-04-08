using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Numerics;
using Slipe.Shared.Utilities;

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
        public Texture(string filePathOrPixels, TextureFormat textureFormat = TextureFormat.Argb, bool mipmaps = true, TextureEdge textureEdge = TextureEdge.Wrap)
        {
            materialElement = MtaClient.DxCreateTexture(filePathOrPixels, textureFormat.ToString().ToLower(), mipmaps, textureEdge.ToString().ToLower());
        }

        /// <summary>
        /// Create an empty texture
        /// </summary>
        public Texture(Vector2 dimensions, TextureFormat textureFormat = TextureFormat.Argb, TextureEdge textureEdge = TextureEdge.Wrap, TextureType textureType = TextureType.TwoDimensional, int depth = 1)
        {
            string textureTypeString = "cube";
            if (textureType == TextureType.TwoDimensional)
                textureTypeString = "2d";
            else if (textureType == TextureType.ThreeDimensional)
                textureTypeString = "3d";

            materialElement = MtaClient.DxCreateTexture((int)dimensions.X, (int)dimensions.Y, textureFormat.ToString().ToLower(), textureEdge.ToString().ToLower(), textureTypeString, depth);
        }

        /// <summary>
        /// Get the pixels of a section of this texture
        /// </summary>
        public TexturePixels GetPixels(Vector2 topLeft, Vector2 dimensions, int surfaceIndex = 0)
        {
            return new TexturePixels(MtaClient.DxGetTexturePixels(surfaceIndex, materialElement, (int) topLeft.X, (int)topLeft.Y, (int)dimensions.X, (int)dimensions.Y));
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
            return MtaClient.DxSetTextureEdge(materialElement, edge == TextureEdge.MirrorOnce ? "mirror-once" : edge.ToString(), borderColor.Hex);
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
            return MtaClient.DxSetTexturePixels(surfaceIndex, materialElement, p, (int) topLeft.X, (int)topLeft.Y, (int)dimensions.X, (int)dimensions.Y);
        }
    }
}
