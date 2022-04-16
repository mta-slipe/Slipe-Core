using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;
using System.Numerics;
using System.ComponentModel;

namespace SlipeLua.Server.Vehicles
{
    /// <summary>
    /// Planes as a special type of vehicle
    /// </summary>
    public class Plane : BaseVehicle
    {
        /// <summary>
        /// Get and set if the Plane's landing gear is down or not
        /// </summary>
        public bool LandingGearDown
        {
            get
            {
                return MtaShared.GetVehicleLandingGearDown(element);
            }
            set
            {
                MtaShared.SetVehicleLandingGearDown(element, value);
            }
        }

        #region Constructors
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Plane(MtaElement element) : base(element) { }

        /// <summary>
        /// Create a plane from a model at a position
        /// </summary>
        public Plane(PlaneModel model, Vector3 position)
            : this(model, position, Vector3.Zero) { }

        /// <summary>
        /// Create a plane using all createVehicle arguments
        /// </summary>
        public Plane(PlaneModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1)
            : base(model, position, rotation, numberplate, variant1, variant2) { }

        #endregion

        public static explicit operator Plane(Vehicle vehicle)
        {
            if (VehicleModel.FromId(vehicle.Model) is PlaneModel)
                return new Plane(vehicle.MTAElement);

            throw (new InvalidCastException("The vehicle is not a plane"));
        }
    }

    /// <summary>
    /// Represents models that represent planes
    /// </summary>
    public class PlaneModel : VehicleModel
    {
        internal PlaneModel(int id) : base(id) { }
    }
}
