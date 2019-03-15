using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;

namespace Slipe.Shared
{
    public class RadarArea : PhysicalElement
    {
        public RadarArea(MTAElement element) : base(element) { }

        public RadarArea(Vector2 position, Vector2 dimensions, Color color, Element visibleTo = null)
        {
            element = MTAShared.CreateRadarArea(position.X, position.Y, dimensions.X, dimensions.Y, color.R, color.G, color.B, color.A, visibleTo == null ? null : visibleTo.MTAElement);
            ElementManager.Instance.RegisterElement(this);
        }

        public RadarArea(Vector2 position, Vector2 dimension) : this (position, dimension, Color.White) { }

        public Color Color
        {
            get
            {
                Tuple<int, int, int, int> tuple = MTAShared.GetRadarAreaColor(element);
                return new Color((byte)tuple.Item1, (byte)tuple.Item2, (byte)tuple.Item3, (byte)tuple.Item4);
            }
            set
            {
                MTAShared.SetRadarAreaColor(element, value.R, value.G, value.B, value.A);
            }
        }

        public Vector2 Size
        {
            get
            {
                Tuple<float, float> tuple = MTAShared.GetRadarAreaSize(element);
                return new Vector2(tuple.Item1, tuple.Item2);
            }
            set
            {
                MTAShared.SetRadarAreaSize(element, value.X, value.Y);
            }
        }

        public bool Flashing
        {
            get
            {
                return MTAShared.IsRadarAreaFlashing(element);
            }
            set
            {
                MTAShared.SetRadarAreaFlashing(element, value);
            }
        }

        public bool isInside(Vector2 position)
        {
            return MTAShared.IsInsideRadarArea(element, position.X, position.Y);
        }


    }
}
