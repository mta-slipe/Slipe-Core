using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System.ComponentModel;

namespace Slipe.Shared.GameWorld
{
    /// <summary>
    /// Class used to create bodies of water on the map
    /// </summary>
    public class SharedWater : PhysicalElement
    {
        /// <summary>
        /// Get the level of this water element
        /// </summary>
        public float Level
        {
            set
            {
                MtaShared.SetWaterLevel(element, value);
            }
        }

        #region Constructors

        /// <summary>
        /// Create water from an MTA water element
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public SharedWater(MtaElement element) : base(element) { }

        /// <summary>
        /// Creates a body of water from 4 corners. Order: SouthWest -> SouthEast -> NorthWest -> NorthEast
        /// </summary>
        public SharedWater(Vector3 southWest, Vector3 southEast, Vector3 northWest, Vector3 northEast, bool shallow = false)
            :this(MtaShared.CreateWater(southWest.X, southWest.Y, southWest.Z, southEast.X, southEast.Y, southEast.Z, northWest.X, northWest.Y, northWest.Z, northEast.X, northEast.Y, northEast.Z, shallow)) { }

        /// <summary>
        /// Creates a body of water from 3 corners. Order: SouthWest -> SouthEast -> NorthWest
        /// </summary>
        public SharedWater(Vector3 southWest, Vector3 southEast, Vector3 northWest, bool shallow = false)
            :this(MtaShared.CreateWater(southWest.X, southWest.Y, southWest.Z, southEast.X, southEast.Y, southEast.Z, northWest.X, northWest.Y, northWest.Z, shallow)) { }

        #endregion

        /// <summary>
        /// Sets the water position of a specific index follow the order SW, SE, NW, NE
        /// </summary>
        public bool SetVertexPosition(int vertexIndex, Vector3 position)
        {
            return MtaShared.SetWaterVertexPosition(element, vertexIndex, (int)position.X, (int)position.Y, position.Z);
        }

        /// <summary>
        /// Gets the world position of a vertex (i.e. corner) of a water area. Follow the order SW, SE, NW, NE
        /// </summary>
        public Vector3 GetVertexPosition(int vertexIndex)
        {
            Tuple<int, int, float> result = MtaShared.GetWaterVertexPosition(element, vertexIndex);
            return new Vector3(result.Item1, result.Item2, result.Item3);
        }
    }
}
