using System;
using System.Collections.Generic;
using System.Text;
using MultiTheftAuto;
using System.Numerics;

namespace MTASharedWrapper
{
    public class RadarArea : PhysicalElement
    {
        public RadarArea() : base()
        {

        }

        public RadarArea(MTAElement element) : base(element)
        {

        }

        public RadarArea(Vector2 position, Vector2 dimensions, Color color, Element visibleTo = null)
        {
            element = Shared.CreateRadarArea(position.X, position.Y, dimensions.X, dimensions.Y, color.R, color.G, color.B, color.A, visibleTo == null ? null : visibleTo.MTAElement);
            ElementManager.Instance.RegisterElement(this);
        }

        public RadarArea(Vector2 position, Vector2 dimension) : this (position, dimension, Color.White)
        {

        }

        public Color Color
        {
            get
            {
                Tuple<int, int, int, int> tuple = Shared.GetRadarAreaColor(element);
                return new Color((byte)tuple.Item1, (byte)tuple.Item2, (byte)tuple.Item3, (byte)tuple.Item4);
            }
            set
            {
                Shared.SetRadarAreaColor(element, value.R, value.G, value.B, value.A);
            }
        }

        public Vector2 Size
        {
            get
            {
                Tuple<float, float> tuple = Shared.GetRadarAreaSize(element);
                return new Vector2(tuple.Item1, tuple.Item2);
            }
            set
            {
                Shared.SetRadarAreaSize(element, value.X, value.Y);
            }
        }

        public bool Flashing
        {
            get
            {
                return Shared.IsRadarAreaFlashing(element);
            }
            set
            {
                Shared.SetRadarAreaFlashing(element, value);
            }
        }

        public bool isInside(Vector2 position)
        {
            return Shared.IsInsideRadarArea(element, position.X, position.Y);
        }


    }
}
