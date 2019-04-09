using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;

namespace Slipe.Shared.Utilities
{
    /// <summary>
    /// Class defining a color and an alpha value
    /// </summary>
    public class Color
    {
        /// <summary>
        /// The red factor of the color
        /// </summary>
        private int r;
        public int R
        {
            get { return r; }
            set { r = value; }
        }

        /// <summary>
        /// The green factor of the color
        /// </summary>
        private int g;
        public int G
        {
            get { return g; }
            set { g = value; }
        }

        /// <summary>
        /// The blue factor of the color
        /// </summary>
        private int b;
        public int B
        {
            get { return b; }
            set { b = value; }
        }

        /// <summary>
        /// The alpha factor of the color
        /// </summary>
        private int a;
        public int A
        {
            get { return a; }
            set { a = value; }
        }

        /// <summary>
        /// Returns the color as a hexadecimal integer
        /// </summary>
        public int Hex
        {
            get
            {
                return MtaShared.Tocolor(R, G, B, A);
            }
        }


        /// <summary>
        /// Creates a color from a hex code
        /// </summary>
        public Color(int hex)
        {

            R = hex / 256 / 256;
            G = (hex - R * 256 * 256) / 256;
            B = hex - R * 256 * 256 - B * 256;
        }

        /// <summary>
        /// Creats a color from a hex code
        /// </summary>
        public Color(uint hex)
        {
            R = (int)(hex / 256 / 256 / 256);
            G = (int)(hex - R * 256 * 256 * 256) / 256 / 256;
            B = (int)(hex - R * 256 * 256 * 256 - G * 256 * 256) / 256;
            A = (int)(hex - R * 256 * 256 * 256 - G * 256 * 256 - B * 256);
        }

        /// <summary>
        /// Creates a color from the individual rgba values
        /// </summary>
        public Color(byte r, byte g, byte b, byte a)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }

        /// <summary>
        /// Creates a color with a solid alpha
        /// </summary>
        public Color(byte r, byte g, byte b) : this(r, g, b, 255)
        {

        }

        public static implicit operator Color(uint color)
        {
            return new Color(color);
        }

        public static implicit operator Color(int color)
        {
            return new Color(color);
        }

        public static Color Maroon { get { return new Color(128, 0, 0); } }
        public static Color rkRed { get { return new Color(139, 0, 0); } }
        public static Color Brown { get { return new Color(165, 42, 42); } }
        public static Color Firebrick { get { return new Color(178, 34, 34); } }
        public static Color Crimson { get { return new Color(220, 20, 60); } }
        public static Color Red { get { return new Color(255, 0, 0); } }
        public static Color Tomato { get { return new Color(255, 99, 71); } }
        public static Color Coral { get { return new Color(255, 127, 80); } }
        public static Color IndianRed { get { return new Color(205, 92, 92); } }
        public static Color LightCoral { get { return new Color(240, 128, 128); } }
        public static Color rkSalmon { get { return new Color(233, 150, 122); } }
        public static Color Salmon { get { return new Color(250, 128, 114); } }
        public static Color LightSalmon { get { return new Color(255, 160, 122); } }
        public static Color OrangeRed { get { return new Color(255, 69, 0); } }
        public static Color rkOrange { get { return new Color(255, 140, 0); } }
        public static Color Orange { get { return new Color(255, 165, 0); } }
        public static Color Gold { get { return new Color(255, 215, 0); } }
        public static Color rkGoldenRod { get { return new Color(184, 134, 11); } }
        public static Color GoldenRod { get { return new Color(218, 165, 32); } }
        public static Color PaleGoldenRod { get { return new Color(238, 232, 170); } }
        public static Color rkKhaki { get { return new Color(189, 183, 107); } }
        public static Color Khaki { get { return new Color(240, 230, 140); } }
        public static Color Olive { get { return new Color(128, 128, 0); } }
        public static Color Yellow { get { return new Color(255, 255, 0); } }
        public static Color YellowGreen { get { return new Color(154, 205, 50); } }
        public static Color rkOliveGreen { get { return new Color(85, 107, 47); } }
        public static Color OliveDrab { get { return new Color(107, 142, 35); } }
        public static Color LawnGreen { get { return new Color(124, 252, 0); } }
        public static Color ChartReuse { get { return new Color(127, 255, 0); } }
        public static Color GreenYellow { get { return new Color(173, 255, 47); } }
        public static Color rkGreen { get { return new Color(0, 100, 0); } }
        public static Color Green { get { return new Color(0, 128, 0); } }
        public static Color ForestGreen { get { return new Color(34, 139, 34); } }
        public static Color Lime { get { return new Color(0, 255, 0); } }
        public static Color LimeGreen { get { return new Color(50, 205, 50); } }
        public static Color LightGreen { get { return new Color(144, 238, 144); } }
        public static Color PaleGreen { get { return new Color(152, 251, 152); } }
        public static Color rkSeaGreen { get { return new Color(143, 188, 143); } }
        public static Color MediumSpringGreen { get { return new Color(0, 250, 154); } }
        public static Color SpringGreen { get { return new Color(0, 255, 127); } }
        public static Color SeaGreen { get { return new Color(46, 139, 87); } }
        public static Color MediumAquaMarine { get { return new Color(102, 205, 170); } }
        public static Color MediumSeaGreen { get { return new Color(60, 179, 113); } }
        public static Color LightSeaGreen { get { return new Color(32, 178, 170); } }
        public static Color rkSlateGray { get { return new Color(47, 79, 79); } }
        public static Color Teal { get { return new Color(0, 128, 128); } }
        public static Color rkCyan { get { return new Color(0, 139, 139); } }
        public static Color Aqua { get { return new Color(0, 255, 255); } }
        public static Color Cyan { get { return new Color(0, 255, 255); } }
        public static Color LightCyan { get { return new Color(224, 255, 255); } }
        public static Color rkTurquoise { get { return new Color(0, 206, 209); } }
        public static Color Turquoise { get { return new Color(64, 224, 208); } }
        public static Color MediumTurquoise { get { return new Color(72, 209, 204); } }
        public static Color PaleTurquoise { get { return new Color(175, 238, 238); } }
        public static Color AquaMarine { get { return new Color(127, 255, 212); } }
        public static Color PowderBlue { get { return new Color(176, 224, 230); } }
        public static Color CadetBlue { get { return new Color(95, 158, 160); } }
        public static Color SteelBlue { get { return new Color(70, 130, 180); } }
        public static Color CornFlowerBlue { get { return new Color(100, 149, 237); } }
        public static Color DeepSkyBlue { get { return new Color(0, 191, 255); } }
        public static Color DodgerBlue { get { return new Color(30, 144, 255); } }
        public static Color LightBlue { get { return new Color(173, 216, 230); } }
        public static Color SkyBlue { get { return new Color(135, 206, 235); } }
        public static Color LightSkyBlue { get { return new Color(135, 206, 250); } }
        public static Color MidnightBlue { get { return new Color(25, 25, 112); } }
        public static Color Navy { get { return new Color(0, 0, 128); } }
        public static Color rkBlue { get { return new Color(0, 0, 139); } }
        public static Color MediumBlue { get { return new Color(0, 0, 205); } }
        public static Color Blue { get { return new Color(0, 0, 255); } }
        public static Color RoyalBlue { get { return new Color(65, 105, 225); } }
        public static Color BlueViolet { get { return new Color(138, 43, 226); } }
        public static Color Indigo { get { return new Color(75, 0, 130); } }
        public static Color rkSlateBlue { get { return new Color(72, 61, 139); } }
        public static Color SlateBlue { get { return new Color(106, 90, 205); } }
        public static Color MediumSlateBlue { get { return new Color(123, 104, 238); } }
        public static Color MediumPurple { get { return new Color(147, 112, 219); } }
        public static Color rkMagenta { get { return new Color(139, 0, 139); } }
        public static Color rkViolet { get { return new Color(148, 0, 211); } }
        public static Color rkOrchid { get { return new Color(153, 50, 204); } }
        public static Color MediumOrchid { get { return new Color(186, 85, 211); } }
        public static Color Purple { get { return new Color(128, 0, 128); } }
        public static Color Thistle { get { return new Color(216, 191, 216); } }
        public static Color Plum { get { return new Color(221, 160, 221); } }
        public static Color Violet { get { return new Color(238, 130, 238); } }
        public static Color Magenta { get { return new Color(255, 0, 255); } }
        public static Color Orchid { get { return new Color(218, 112, 214); } }
        public static Color MediumVioletRed { get { return new Color(199, 21, 133); } }
        public static Color PaleVioletRed { get { return new Color(219, 112, 147); } }
        public static Color DeepPink { get { return new Color(255, 20, 147); } }
        public static Color HotPink { get { return new Color(255, 105, 180); } }
        public static Color LightPink { get { return new Color(255, 182, 193); } }
        public static Color Pink { get { return new Color(255, 192, 203); } }
        public static Color AntiqueWhite { get { return new Color(250, 235, 215); } }
        public static Color Beige { get { return new Color(245, 245, 220); } }
        public static Color Bisque { get { return new Color(255, 228, 196); } }
        public static Color Blanchelmond { get { return new Color(255, 235, 205); } }
        public static Color Wheat { get { return new Color(245, 222, 179); } }
        public static Color CornSilk { get { return new Color(255, 248, 220); } }
        public static Color LemonChion { get { return new Color(255, 250, 205); } }
        public static Color LightGoldenRodYellow { get { return new Color(250, 250, 210); } }
        public static Color LightYellow { get { return new Color(255, 255, 224); } }
        public static Color SaddleBrown { get { return new Color(139, 69, 19); } }
        public static Color Sienna { get { return new Color(160, 82, 45); } }
        public static Color Chocolate { get { return new Color(210, 105, 30); } }
        public static Color Peru { get { return new Color(205, 133, 63); } }
        public static Color SandyBrown { get { return new Color(244, 164, 96); } }
        public static Color BurlyWood { get { return new Color(222, 184, 135); } }
        public static Color Tan { get { return new Color(210, 180, 140); } }
        public static Color RosyBrown { get { return new Color(188, 143, 143); } }
        public static Color Moccasin { get { return new Color(255, 228, 181); } }
        public static Color NavajoWhite { get { return new Color(255, 222, 173); } }
        public static Color PeachPu { get { return new Color(255, 218, 185); } }
        public static Color MistyRose { get { return new Color(255, 228, 225); } }
        public static Color LavenderBlush { get { return new Color(255, 240, 245); } }
        public static Color Linen { get { return new Color(250, 240, 230); } }
        public static Color OldLace { get { return new Color(253, 245, 230); } }
        public static Color PapayaWhip { get { return new Color(255, 239, 213); } }
        public static Color SeaShell { get { return new Color(255, 245, 238); } }
        public static Color MintCream { get { return new Color(245, 255, 250); } }
        public static Color SlateGray { get { return new Color(112, 128, 144); } }
        public static Color LightSlateGray { get { return new Color(119, 136, 153); } }
        public static Color LightSteelBlue { get { return new Color(176, 196, 222); } }
        public static Color Lavender { get { return new Color(230, 230, 250); } }
        public static Color FloralWhite { get { return new Color(255, 250, 240); } }
        public static Color AliceBlue { get { return new Color(240, 248, 255); } }
        public static Color GhostWhite { get { return new Color(248, 248, 255); } }
        public static Color Honeydew { get { return new Color(240, 255, 240); } }
        public static Color Ivory { get { return new Color(255, 255, 240); } }
        public static Color Azure { get { return new Color(240, 255, 255); } }
        public static Color Snow { get { return new Color(255, 250, 250); } }
        public static Color Black { get { return new Color(0, 0, 0); } }
        public static Color DimGray { get { return new Color(105, 105, 105); } }
        public static Color Gray { get { return new Color(128, 128, 128); } }
        public static Color rkGray { get { return new Color(169, 169, 169); } }
        public static Color Silver { get { return new Color(192, 192, 192); } }
        public static Color LightGray { get { return new Color(211, 211, 211); } }
        public static Color Gainsboro { get { return new Color(220, 220, 220); } }
        public static Color WhiteSmoke { get { return new Color(245, 245, 245); } }
        public static Color White { get { return new Color(255, 255, 255); } }

    }
}
