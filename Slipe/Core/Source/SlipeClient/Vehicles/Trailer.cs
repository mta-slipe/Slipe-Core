using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;
using Slipe.Shared;

namespace Slipe.Client.Vehicles
{
    /// <summary>
    /// Represents a towable trailer
    /// </summary>
    public class Trailer : BaseVehicle
    {
        /// <summary>
        /// Get and set the vehicle towing this trailer
        /// </summary>
        public Vehicle TowingVehicle
        {
            get
            {
                return (Vehicle) ElementManager.Instance.GetElement(MTAShared.GetVehicleTowingVehicle(element));
            }
            set
            {
                AttachTo(value);
            }
        }

        /// <summary>
        /// Create a vehicle from a model at a position
        /// </summary>
        public Trailer(TrailerModel model, Vector3 position) : base(model, position)
        {

        }

        /// <summary>
        /// Create a vehicle model using all createVehicle arguments
        /// </summary>
        public Trailer(TrailerModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1) : base(model, position, rotation, numberplate, variant1, variant2)
        {
        }

        /// <summary>
        /// Create a vehicle from an MTA vehicle element 
        /// </summary>
        public Trailer(MTAElement element) : base(element)
        {

        }

        /// <summary>
        /// Attach this trailer to a vehicle
        /// </summary>
        public bool AttachTo(Vehicle vehicle)
        {
            return MTAShared.AttachTrailerToVehicle(element, vehicle.MTAElement);
        }
    }

    /// <summary>
    /// Represents different trailer models
    /// </summary>
    public class TrailerModel : BaseVehicleModel
    {
        public static TrailerModel BaggageCovered { get { return new TrailerModel(606); } }
        public static TrailerModel BaggageUncovered { get { return new TrailerModel(607); } }
        public static TrailerModel Steps { get { return new TrailerModel(608); } }
        public static TrailerModel Farmtrailer { get { return new TrailerModel(610); } }
        public static TrailerModel Streetcleaner { get { return new TrailerModel(611); } }
        public static TrailerModel GasSemi { get { return new TrailerModel(584); } }
        public static TrailerModel Semi { get { return new TrailerModel(435); } }
        public static TrailerModel OpenSemi { get { return new TrailerModel(450); } }
        public static TrailerModel SmallSemi { get { return new TrailerModel(591); } }
        protected TrailerModel(int id) : base(id) { }
    }
}
