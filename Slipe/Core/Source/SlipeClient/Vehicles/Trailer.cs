using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Numerics;
using Slipe.Shared.Elements;
using System.ComponentModel;

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
        public BaseVehicle TowingVehicle
        {
            get
            {
                return ElementManager.Instance.GetElement<BaseVehicle>(MtaShared.GetVehicleTowingVehicle(element));
            }
            set
            {
                AttachTo(value);
            }
        }

        #region Constructors
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Trailer(MtaElement element) : base(element) { }

        /// <summary>
        /// Create a plane from a model at a position
        /// </summary>
        public Trailer(TrailerModel model, Vector3 position)
            : this(model, position, Vector3.Zero) { }

        /// <summary>
        /// Create a plane using all createVehicle arguments
        /// </summary>
        public Trailer(TrailerModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1)
            : base(model, position, rotation, numberplate, variant1, variant2) { }

        #endregion

        public static explicit operator Trailer(Vehicle vehicle)
        {
            if (VehicleModel.FromId(vehicle.Model) is TrailerModel)
                return new Trailer(vehicle.MTAElement);

            throw (new InvalidCastException("The vehicle is not a trailer"));
        }

        /// <summary>
        /// Attach this trailer to a vehicle
        /// </summary>
        public bool AttachTo(BaseVehicle vehicle)
        {
            return MtaShared.AttachTrailerToVehicle(element, vehicle.MTAElement);
        }

        #region Events

        #pragma warning disable 67

        public delegate void OnAttachHandler(BaseVehicle truck);
        public event OnAttachHandler OnAttach;

        public delegate void OnDetachHandler(BaseVehicle truck);
        public event OnDetachHandler OnDetach;

        #pragma warning restore 67

        #endregion
    }

    /// <summary>
    /// Represents different trailer models
    /// </summary>
    public class TrailerModel : VehicleModel
    {
        internal TrailerModel(int id) : base(id) { }
    }
}
