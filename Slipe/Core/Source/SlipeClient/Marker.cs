using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;
using Slipe.Shared.Elements;
using Slipe.Shared.Utilities;
using Slipe.Shared.Markers;

namespace Slipe.Client
{
    /// <summary>
    /// Class that represents different types of markers
    /// </summary>
    public class Marker : SharedMarker
    {
        /// <summary>
        /// Creates a marker from an MTA marker element
        /// </summary>
        public Marker(MTAElement element) : base(element) { }

        /// <summary>
        /// Create a marker form all the createMarker parameters
        /// </summary>
        public Marker(Vector3 position, MarkerType type, Color color, float size = 4.0f)
        {
            element = MTAClient.CreateMarker(position.X, position.Y, position.Z, type.ToString(), size, color.R, color.G, color.B, color.A);
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Creates a marker from just a position and type
        /// </summary>
        public Marker(Vector3 position, MarkerType type) : this(position, type, Color.Red) { }
    }
}