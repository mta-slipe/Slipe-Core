using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;

namespace Slipe.Shared
{
    /// <summary>
    /// Class representing a (mini)map radar area
    /// </summary>
    public class SharedRadarArea : PhysicalElement
    {

        /// <summary>
        /// Creates or retrieves a radar area from an MTA radar area element
        /// </summary>
        public SharedRadarArea(MTAElement element) : base(element) { }

        /// <summary>
        /// Creates a radar area from the createRadarArea parameters
        /// </summary>
        public SharedRadarArea(Vector2 position, Vector2 dimensions, Color color, Element visibleTo = null)
        {
            element = MTAShared.CreateRadarArea(position.X, position.Y, dimensions.X, dimensions.Y, color.R, color.G, color.B, color.A, visibleTo == null ? null : visibleTo.MTAElement);
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Creats a white radar area from just a position and a dimension
        /// </summary>
        public SharedRadarArea(Vector2 position, Vector2 dimension) : this (position, dimension, Color.White) { }

        /// <summary>
        /// Gets and sets the radar area color
        /// </summary>
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

        /// <summary>
        /// Gets and sets the dimensions of the radar area
        /// </summary>
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

        /// <summary>
        /// Gets or sets the flashing state of the radar area
        /// </summary>
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

        /// <summary>
        /// Checks if a certain 2D position is inside a radar area
        /// </summary>
        public bool isInside(Vector2 position)
        {
            return MTAShared.IsInsideRadarArea(element, position.X, position.Y);
        }

        /// <summary>
        /// Checks if a certain 3D position is inside a radar area
        /// </summary>
        public bool isInside(Vector3 position)
        {
            return MTAShared.IsInsideRadarArea(element, position.X, position.Y);
        }


    }
}
