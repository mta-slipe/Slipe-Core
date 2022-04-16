using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Utilities;
using System.ComponentModel;
using SlipeLua.Shared.Markers.Events;

namespace SlipeLua.Shared.Markers
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
                return MtaShared.GetMarkerCount();
            }
        }

        /// <summary>
        /// Get and set the color of this marker
        /// </summary>
        public Color Color
        {
            get
            {
                Tuple<int, int, int, int> tuple = MtaShared.GetMarkerColor(element);
                return new Color((byte)tuple.Item1, (byte)tuple.Item2, (byte)tuple.Item3, (byte)tuple.Item4);
            }
            set
            {
                MtaShared.SetMarkerColor(element, value.R, value.G, value.B, value.A);
            }
        }

        /// <summary>
        /// Get and set the icon type of this marker
        /// </summary>
        public MarkerIcon Icon
        {
            get
            {
                Enum.TryParse(MtaShared.GetMarkerIcon(element), true, out MarkerIcon result);
                return result;
            }
            set
            {
                MtaShared.SetMarkerIcon(element, value.ToString().ToLower());
            }
        }

        /// <summary>
        /// Get and set the size of the marker (default is 4.0f)
        /// </summary>
        public float Size
        {
            get
            {
                return MtaShared.GetMarkerSize(element);
            }
            set
            {
                MtaShared.SetMarkerSize(element, value);
            }
        }

        /// <summary>
        /// Get and set the target position the marker is facing
        /// </summary>
        public Vector3 Target
        {
            get
            {
                Tuple<float, float, float> result = MtaShared.GetMarkerTarget(element);
                return new Vector3(result.Item1, result.Item2, result.Item3);
            }
            set
            {
                MtaShared.SetMarkerTarget(element, value.X, value.Y, value.Z);
            }
        }

        /// <summary>
        /// Get and set the type of this marker
        /// </summary>
        public MarkerType MarkerType
        {
            get
            {
                Enum.TryParse(MtaShared.GetMarkerType(element), true, out MarkerType result);
                return result;
            }
            set
            {
                MtaShared.SetMarkerType(element, value.ToString().ToLower());
            }
        }

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public SharedMarker(MtaElement element) : base(element)
        {

        }

        #endregion

        #region Events

        #pragma warning disable 67

        public delegate void OnHitHandler(SharedMarker source, OnHitEventArgs eventArgs);
        public event OnHitHandler OnHit;

        public delegate void OnLeaveHandler(SharedMarker source, OnLeaveEventArgs eventArgs);
        public event OnLeaveHandler OnLeave;

        #pragma warning restore 67

        #endregion
    }
}
