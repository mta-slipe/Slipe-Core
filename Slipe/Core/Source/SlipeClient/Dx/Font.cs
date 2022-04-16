using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.Client.Enums;
using SlipeLua.MtaDefinitions;

namespace SlipeLua.Client.Dx
{
    /// <summary>
    /// Class representing custom font elements
    /// </summary>
    public class Font
    {
        private MtaElement _font;

        /// <summary>
        /// Get the MTA font element used
        /// </summary>
        public MtaElement MTAFont
        {
            get
            {
                return _font;
            }
        }

        /// <summary>
        /// Create a new font from a path
        /// </summary>
        public Font(string filePath, int size = 9, bool bold = false, FontQuality quality = FontQuality.Default)
        {
            _font = MtaClient.DxCreateFont(filePath, size, bold, quality.ToString().ToLower());
        }

        /// <summary>
        /// Get the height of this font
        /// </summary>
        public int GetHeight(float scale = 1)
        {
            return MtaClient.DxGetFontHeight(scale, _font);
        }

        /// <summary>
        /// Get the height of a GTA font
        /// </summary>
        public static int GetHeight(StandardFont font = StandardFont.Default, float scale = 1)
        {
            return MtaClient.DxGetFontHeight(scale, font.ToString().ToLower());
        }

        /// <summary>
        /// Get the height of a custom font
        /// </summary>
        public static int GetHeight(Font font, float scale = 1)
        {
            return MtaClient.DxGetFontHeight(scale, font.MTAFont);
        }
    }
}
