using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Numerics;
using System.ComponentModel;
using Slipe.Shared.GameWorld;
using Slipe.Shared.Elements;

namespace Slipe.Client.GameWorld
{
    /// <summary>
    /// Class used to create bodies of water on the map
    /// </summary>
    [DefaultElementClass("water")]
    public class Water : SharedWater
    {
        /// <summary>
        /// Get and set the water level of this water body
        /// </summary>
        public new float Level
        {
            get
            {
                return MtaClient.GetWaterLevel(element);
            }
            set
            {
                MtaShared.SetWaterLevel(element, value);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DefaultElementConstructor]
        public Water(MtaElement element) : base(element) { }

        /// <summary>
        /// Creates a body of water from 4 corners. The order of the input vectors doesn't matter
        /// </summary>
        public Water(Vector3 corner1, Vector3 corner2, Vector3 corner3, Vector3 corner4, bool shallow = false) : base(corner1, corner2, corner3, corner4, shallow) { }

        /// <summary>
        /// Creates a body of water from 3 corners. The order of the input vectors doesn't matter
        /// </summary>
        public Water(Vector3 corner1, Vector3 corner2, Vector3 corner3, bool shallow = false) : base(corner1, corner2, corner3, shallow) { }
    }
}
