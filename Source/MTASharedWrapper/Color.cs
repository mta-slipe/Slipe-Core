using System;
using System.Collections.Generic;
using System.Text;

namespace MTASharedWrapper
{
    public class Color
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public int A { get; set; }

        public Color(int hex)
        {

            this.R = (hex / 256 / 256);
            this.G = (hex - this.R * 256 * 256) / 256;
            this.B = (hex - this.R * 256 * 256 - this.B * 256);
        }

        public Color(byte r, byte g, byte b, byte a)
        {
            this.R = r;
            this.G = g;
            this.B = b;
            this.A = a;
        }

        public Color(byte r, byte g, byte b): this(r, g, b, 255)
        {

        }
    }
}
