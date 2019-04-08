using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Vehicles;
using System.Numerics;
using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;

namespace Slipe.Server.Vehicles
{
    public class BaseVehicleModel : SharedVehicleModel
    {
        /// <summary>
        /// Get the model handling of this vehicle model
        /// </summary>
        public ModelHandling Handling
        {
            get
            {
                return new ModelHandling(id);
            }
        }

        /// <summary>
        /// Get all the vehicles using this model in the server
        /// </summary>
        public Vehicle[] Vehicles
        {
            get
            {
                MtaElement[] mtaElements = MtaShared.GetArrayFromTable(MtaServer.GetVehiclesOfType(id), "MTAElement");
                return ElementManager.Instance.CastArray<Vehicle>(mtaElements);
            }
        }

        protected BaseVehicleModel(int id) : base(id) { }
    }
}