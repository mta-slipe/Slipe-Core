using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;
using Slipe.Shared.GameWorld;

namespace Slipe.Client
{
    /// <summary>
    /// Class wrapping a garage as seen in singleplayer
    /// </summary>
    public class Garage : SharedGarage
    {
        public Garage(GarageLocation garage) : base(garage) { }

        /// <summary>
        /// Get the bounding box of a garage.
        /// </summary>
        public Vector4 BoundingBox
        {
            get
            {
                Tuple<float, float, float, float> result = MTAClient.GetGarageBoundingBox(_garageID);
                return new Vector4(result.Item1, result.Item2, result.Item3, result.Item4);
            }
        }

        /// <summary>
        /// Gets the coordinates of the garage
        /// </summary>
        public Vector3 Position
        {
            get
            {
                Tuple<float, float, float> result = MTAClient.GetGaragePosition(_garageID);
                return new Vector3(result.Item1, result.Item2, result.Item3);
            }
        }

        /// <summary>
        /// Get the size of the garage
        /// </summary>
        public Vector3 Size
        {
            get
            {
                Tuple<float, float, float> result = MTAClient.GetGarageSize(_garageID);
                return new Vector3(result.Item1, result.Item2, result.Item3);
            }
        }
    }
}
