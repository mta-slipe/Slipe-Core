using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Client.Enums;
using Slipe.MTADefinitions;

namespace Slipe.Client.Dx
{
    /// <summary>
    /// Class representing custom font elements
    /// </summary>
    public class Font
    {
        private MTAElement _font;

        /// <summary>
        /// Get the MTA font element used
        /// </summary>
        public MTAElement MTAFont
        {
            get
            {
                return _font;
            }
        }

        /// <summary>
        /// Create a new font from a path
        /// </summary>
        public Font(string filePath, int size = 9, bool bold = false, FontQualityEnum quality = FontQualityEnum.DEFAULT)
        {
            _font = MTAClient.DxCreateFont(filePath, size, bold, quality.ToString().ToLower());
        }

        /// <summary>
        /// Get the height of this font
        /// </summary>
        public int GetHeight(float scale = 1)
        {
            return MTAClient.DxGetFontHeight(scale, _font);
        }

        /// <summary>
        /// Get the heigh tof a GTA font
        /// </summary>
        public static int GetHeight(StandardFontEnum font = StandardFontEnum.DEFAULT, float scale = 1)
        {
            return MTAClient.DxGetFontHeight(scale, font.ToString().ToLower());
        }

        /// <summary>
        /// Get the height of a custom font
        /// </summary>
        public static int GetHeight(Font font, float scale = 1)
        {
            return MTAClient.DxGetFontHeight(scale, font.MTAFont);
        }
    }
}
