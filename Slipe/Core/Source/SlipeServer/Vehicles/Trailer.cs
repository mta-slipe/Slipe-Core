using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Numerics;
using Slipe.Shared.Elements;
using System.ComponentModel;

namespace Slipe.Server.Vehicles
{
    /// <summary>
    /// Represents a towable trailer
    /// </summary>
    public class Trailer : Vehicle
    {
        /// <summary>
        /// Get and set the vehicle towing this trailer
        /// </summary>
        public Vehicle TowingVehicle
        {
            get
            {
                return ElementManager.Instance.GetElement<Vehicle>(MtaShared.GetVehicleTowingVehicle(element));
            }
            set
            {
                AttachTo(value);
            }
        }

        #region Constructors

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

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Trailer(MtaElement element) : base(element)
        {
        }

        #endregion

        /// <summary>
        /// Attach this trailer to a vehicle
        /// </summary>
        public bool AttachTo(Vehicle vehicle)
        {
            return MtaShared.AttachTrailerToVehicle(element, vehicle.MTAElement);
        }

        #region Events

        #pragma warning disable 67

        public delegate void OnAttachHandler(Vehicle truck);
        public event OnAttachHandler OnAttach;

        public delegate void OnDetachHandler(Vehicle truck);
        public event OnDetachHandler OnDetach;

        #pragma warning restore 67

        #endregion
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
