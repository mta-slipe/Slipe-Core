﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Utilities;
using SlipeLua.Shared.Markers;
using System.ComponentModel;

namespace SlipeLua.Server.Markers
{
    /// <summary>
    /// Class that represents different types of markers
    /// </summary>
    [DefaultElementClass(ElementType.Marker)]
    public class Marker : SharedMarker
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Marker(MtaElement element) : base(element) { }

        /// <summary>
        /// Create a marker form all the createMarker parameters
        /// </summary>
        public Marker(Vector3 position, MarkerType type, Color color, float size = 4.0f, Element visibleTo = null)
            : this(MtaServer.CreateMarker(position.X, position.Y, position.Z, type.ToString().ToLower(), size, color.R, color.G, color.B, color.A, visibleTo?.MTAElement)) { }

        /// <summary>
        /// Creates a marker from just a position and type
        /// </summary>
        public Marker(Vector3 position, MarkerType type) 
            : this(position, type, Color.Red) { }
    }
}
