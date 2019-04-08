using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Vehicles;
using Slipe.MtaDefinitions;
using System.Numerics;

namespace Slipe.Client.Vehicles
{
    public class BaseVehicleModel : SharedVehicleModel
    {
        /// <summary>
        /// Get and set the position of the exhaust fumes the vehicle model emits.
        /// </summary>
        public Vector3 ExhaustPosition
        {
            get
            {
                Tuple<float, float, float> r = MtaClient.GetVehicleModelExhaustFumesPosition(id);
                return new Vector3(r.Item1, r.Item2, r.Item3);
            }
            set
            {
                MtaClient.SetVehicleModelExhaustFumesPosition(id, value.X, value.Y, value.Z);
            }
        }

        protected BaseVehicleModel(int id) : base(id) { }
    }
}
