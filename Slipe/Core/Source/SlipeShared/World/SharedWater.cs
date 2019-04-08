using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;
using Slipe.Shared.Elements;
using System.ComponentModel;

namespace Slipe.Shared.World
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
                MTAShared.SetWaterLevel(element, value);
            }
        }

        #region Constructors

        /// <summary>
        /// Create water from an MTA water element
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public SharedWater(MTAElement element) : base(element) { }

        /// <summary>
        /// Creates a body of water from 4 corners. The order of the input vectors doesn't matter
        /// </summary>
        public SharedWater(Vector3 corner1, Vector3 corner2, Vector3 corner3, Vector3 corner4, bool shallow = false)
        {
            Vector3 southWest = new Vector3(3000, 3000, 0);
            Vector3 southEast = new Vector3(-3000, 3000, 0);
            Vector3 northWest = new Vector3(3000, -3000, 0);
            Vector3 northEast = new Vector3(-3000, -3000, 0);

            Vector3[] vectors = new Vector3[] { corner1, corner2, corner3, corner4 };

            foreach (Vector3 v in vectors)
            {
                // North-East
                if (v.X > northEast.X && v.Y > northEast.Y)
                    northEast = v;
                // South-West
                if (v.X < southWest.X && v.Y < southWest.Y)
                    southWest = v;
                // North-West
                if (v.X < northWest.X && v.Y > northWest.Y)
                    northWest = v;
                // South-East
                if (v.X > southEast.X && v.Y < southEast.Y)
                    southEast = v;
            }

            element = MTAShared.CreateWater(southWest.X, southWest.Y, southWest.Z, southEast.X, southEast.Y, southEast.Z, northWest.X, northWest.Y, northWest.Z, northEast.X, northEast.Y, northEast.Z, shallow);
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Creates a body of water from 3 corners. The order of the input vectors doesn't matter
        /// </summary>
        public SharedWater(Vector3 corner1, Vector3 corner2, Vector3 corner3, bool shallow = false)
        {
            Vector3 southWest = new Vector3(3000, 3000, 0);
            Vector3 southEast = new Vector3(-3000, 3000, 0);
            Vector3 northWest = new Vector3(3000, -3000, 0);

            Vector3[] vectors = new Vector3[] { corner1, corner2, corner3 };

            foreach (Vector3 v in vectors)
            {
                // South-West
                if (v.X < southWest.X && v.Y < southWest.Y)
                    southWest = v;
                // North-West
                if (v.X < northWest.X && v.Y > northWest.Y)
                    northWest = v;
                // South-East
                if (v.X > southEast.X && v.Y < southEast.Y)
                    southEast = v;
            }

            element = MTAShared.CreateWater(southWest.X, southWest.Y, southWest.Z, southEast.X, southEast.Y, southEast.Z, northWest.X, northWest.Y, northWest.Z, shallow);
            ElementManager.Instance.RegisterElement(this);
        }

        #endregion

        /// <summary>
        /// Sets the water position of a specific index follow the order SW, SE, NW, NE
        /// </summary>
        public bool SetVertexPosition(int vertexIndex, Vector3 position)
        {
            return MTAShared.SetWaterVertexPosition(element, vertexIndex, (int)position.X, (int)position.Y, position.Z);
        }

        /// <summary>
        /// Gets the world position of a vertex (i.e. corner) of a water area. Follow the order SW, SE, NW, NE
        /// </summary>
        public Vector3 GetVertexPosition(int vertexIndex)
        {
            Tuple<int, int, float> result = MTAShared.GetWaterVertexPosition(element, vertexIndex);
            return new Vector3(result.Item1, result.Item2, result.Item3);
        }
    }
}
