using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared
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
        /// Creates a color from a hex code
        /// </summary>
        public Color(int hex)
        {

            this.R = (hex / 256 / 256);
            this.G = (hex - this.R * 256 * 256) / 256;
            this.B = (hex - this.R * 256 * 256 - this.B * 256);
        }

        /// <summary>
        /// Creats a color from a hex code
        /// </summary>
        public Color(uint hex)
        {
            this.R = (int)(hex / 256 / 256 / 256);
            this.G = (int)(hex - this.R * 256 * 256 * 256) / 256 / 256;
            this.B = (int)(hex - this.R * 256 * 256 * 256 - this.G * 256 * 256) / 256;
            this.A = (int)(hex - this.R * 256 * 256 * 256 - this.G * 256 * 256 - this.B * 256);
        }

        /// <summary>
        /// Creates a color from the individual rgba values
        /// </summary>
        public Color(byte r, byte g, byte b, byte a)
        {
            this.R = r;
            this.G = g;
            this.B = b;
            this.A = a;
        }

        /// <summary>
        /// Creates a color with a solid alpha
        /// </summary>
        public Color(byte r, byte g, byte b): this(r, g, b, 255)
        {

        }

        /// <summary>
        /// Returns red
        /// </summary>
        public static Color Red
        {
            get { return new Color(255, 0, 0); }
        }

        /// <summary>
        /// Returns white
        /// </summary>
        public static Color White
        {
            get { return new Color(255, 255, 255); }
        }
    }
}
