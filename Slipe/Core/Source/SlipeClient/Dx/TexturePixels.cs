using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MtaDefinitions;
using Slipe.Shared.Utilities;

namespace Slipe.Client.Dx
{
    /// <summary>
    /// Represents a data format of pixels of a texture element
    /// </summary>
    public class TexturePixels
    {
        private string pixels;

        /// <summary>
        /// Create a Texturepixels object from a pixel string
        /// </summary>
        public TexturePixels(string pixelString)
        {
            pixels = pixelString; // MTAClient.DxConvertPixels(pixelString, "plain", 80);
        }

        /// <summary>
        /// Converts the pixels to a certain image format
        /// </summary>
        public string Convert(ImageFormat format, int quality = 80)
        {
            return MtaClient.DxConvertPixels(pixels, format.ToString(), quality);
        }

        /// <summary>
        /// This function gets the color of a single pixel from pixels contained in a string. 
        /// </summary>
        public Color GetPixelColor(Vector2 coordinate)
        {
            string p = pixels;
            if (Format != ImageFormat.plain)
                p = Convert(ImageFormat.plain);

            Tuple<int, int, int, int> result = MtaClient.DxGetPixelColor(p, (int) coordinate.X, (int) coordinate.Y);
            return new Color((byte) result.Item1, (byte)result.Item2, (byte)result.Item3, (byte)result.Item4);
        }

        /// <summary>
        /// This function sets the color of a single pixel for pixels contained in a string. Converts format to plain
        /// </summary>
        public bool SetPixelColor(Vector2 coordinate, Color color)
        {
            if (Format != ImageFormat.plain)
                pixels = Convert(ImageFormat.plain);

            return MtaClient.DxSetPixelColor(pixels, (int) coordinate.X, (int) coordinate.Y, color.R, color.G, color.B, color.A);
        }

        /// <summary>
        /// This function gets the dimensions of pixels contained in a string
        /// </summary>
        public Vector2 Size
        {
            get
            {
                Tuple<int, int> result = MtaClient.DxGetPixelsSize(pixels);
                return new Vector2(result.Item1, result.Item2);
            }
        }

        /// <summary>
        /// Get the format of pixels
        /// </summary>
        public ImageFormat Format
        {
            get
            {
                return (ImageFormat) Enum.Parse(typeof(ImageFormat), MtaClient.DxGetPixelsFormat(pixels));
            }
        }
    }
}
