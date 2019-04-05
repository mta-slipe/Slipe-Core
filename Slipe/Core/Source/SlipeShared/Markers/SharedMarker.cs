using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;
using Slipe.Shared.Elements;
using Slipe.Shared.Utilities;

namespace Slipe.Shared.Markers
{
    /// <summary>
    /// Class that represents different types of markers
    /// </summary>
    public class SharedMarker : PhysicalElement
    {
        #region Properties

        /// <summary>
        /// Get the total amount of markers in the world
        /// </summary>
        public static int Count
        {
            get
            {
                return MTAShared.GetMarkerCount();
            }
        }

        /// <summary>
        /// Get and set the color of this marker
        /// </summary>
        public Color Color
        {
            get
            {
                Tuple<int, int, int, int> tuple = MTAShared.GetMarkerColor(element);
                return new Color((byte)tuple.Item1, (byte)tuple.Item2, (byte)tuple.Item3, (byte)tuple.Item4);
            }
            set
            {
                MTAShared.SetMarkerColor(element, value.R, value.G, value.B, value.A);
            }
        }

        /// <summary>
        /// Get and set the icon type of this marker
        /// </summary>
        public MarkerIcon Icon
        {
            get
            {
                Enum.TryParse(MTAShared.GetMarkerIcon(element), true, out MarkerIcon result);
                return result;
            }
            set
            {
                MTAShared.SetMarkerIcon(element, value.ToString().ToLower());
            }
        }

        /// <summary>
        /// Get and set the size of the marker (default is 4.0f)
        /// </summary>
        public float Size
        {
            get
            {
                return MTAShared.GetMarkerSize(element);
            }
            set
            {
                MTAShared.SetMarkerSize(element, value);
            }
        }

        /// <summary>
        /// Get and set the target position the marker is facing
        /// </summary>
        public Vector3 Target
        {
            get
            {
                Tuple<float, float, float> result = MTAShared.GetMarkerTarget(element);
                return new Vector3(result.Item1, result.Item2, result.Item3);
            }
            set
            {
                MTAShared.SetMarkerTarget(element, value.X, value.Y, value.Z);
            }
        }

        /// <summary>
        /// Get and set the type of this marker
        /// </summary>
        public MarkerType MarkerType
        {
            get
            {
                Enum.TryParse(MTAShared.GetMarkerType(element), true, out MarkerType result);
                return result;
            }
            set
            {
                MTAShared.SetMarkerType(element, value.ToString().ToLower());
            }
        }

        #endregion

        #region Constructors

        protected SharedMarker() : base() { }

        /// <summary>
        /// Creates a marker from an MTA marker element
        /// </summary>
        public SharedMarker(MTAElement element) : base(element) { }

        #endregion



    }
}
