﻿using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared;
using Slipe.MTADefinitions;
using System.Numerics;

namespace Slipe.Client
{
    /// <summary>
    /// Class used to create bodies of water on the map
    /// </summary>
    public class Water : SharedWater
    {
        /// <summary>
        /// Create water from an MTA water element
        /// </summary>
        public Water(MTAElement element) : base(element) { }

        /// <summary>
        /// Creates a body of water from 4 corners. The order of the input vectors doesn't matter
        /// </summary>
        public Water(Vector3 corner1, Vector3 corner2, Vector3 corner3, Vector3 corner4, bool shallow = false) : base(corner1, corner2, corner3, corner4, shallow) { }

        /// <summary>
        /// Creates a body of water from 3 corners. The order of the input vectors doesn't matter
        /// </summary>
        public Water(Vector3 corner1, Vector3 corner2, Vector3 corner3, bool shallow = false) : base(corner1, corner2, corner3, shallow) { }

        /// <summary>
        /// Get and set the water level of this water body
        /// </summary>
        public new float Level
        {
            get
            {
                return MTAClient.GetWaterLevel(element);
            }
            set
            {
                MTAShared.SetWaterLevel(element, value);
            }
        }
    }
}