using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Slipe.Client.Vehicles
{
    /// <summary>
    /// Represents a "dummy" part of a vehicle model
    /// </summary>
    public class VehicleModelDummy
    {
        private VehicleModel model;
        private string dummyName;

        /// <summary>
        /// Get and set the position of the dummy
        /// </summary>
        public Vector3 Position
        {
            get
            {
                Tuple<float, float, float> r = MtaClient.GetVehicleModelDummyPosition(model.Id, dummyName);
                return new Vector3(r.Item1, r.Item2, r.Item3);
            }
            set
            {
                MtaClient.SetVehicleModelDummyPosition(model.Id, dummyName, value.X, value.Y, value.Z);
            }
        }

        internal VehicleModelDummy(VehicleModel model, string dummyName)
        {
            this.model = model;
            this.dummyName = dummyName;
        }
    }
}
