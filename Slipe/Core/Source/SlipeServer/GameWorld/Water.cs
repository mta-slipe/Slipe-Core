using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;
using System.Numerics;
using System.ComponentModel;
using SlipeLua.Shared.GameWorld;
using SlipeLua.Shared.Elements;

namespace SlipeLua.Server.GameWorld
{
    /// <summary>
    /// Class used to create bodies of water on the map
    /// </summary>
    [DefaultElementClass(ElementType.Water)]
    public class Water : SharedWater
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Water(MtaElement element) : base(element) { }

        /// <summary>
        /// Creates a body of water from 4 corners.
        /// </summary>
        public Water(Vector3 corner1, Vector3 corner2, Vector3 corner3, Vector3 corner4, bool shallow = false) : base(corner1, corner2, corner3, corner4, shallow) { }

        /// <summary>
        /// Creates a body of water from 3 corners.
        /// </summary>
        public Water(Vector3 corner1, Vector3 corner2, Vector3 corner3, bool shallow = false) : base(corner1, corner2, corner3, shallow) { }
    }
}
