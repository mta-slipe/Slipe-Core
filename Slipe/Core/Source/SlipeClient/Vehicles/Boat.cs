using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using SlipeLua.MtaDefinitions;
using System.ComponentModel;

namespace SlipeLua.Client.Vehicles
{
    /// <summary>
    /// Represents boats
    /// </summary>
    public class Boat : BaseVehicle
    {
        #region Constructors
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Boat(MtaElement element) : base(element) { }

        /// <summary>
        /// Create a plane from a model at a position
        /// </summary>
        public Boat(BoatModel model, Vector3 position)
            : this(model, position, Vector3.Zero) { }

        /// <summary>
        /// Create a plane using all createVehicle arguments
        /// </summary>
        public Boat(BoatModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1)
            : base(model, position, rotation, numberplate, variant1, variant2) { }

        #endregion

        public static explicit operator Boat(Vehicle vehicle)
        {
            if (VehicleModel.FromId(vehicle.Model) is BoatModel)
                return new Boat(vehicle.MTAElement);

            throw (new InvalidCastException("The vehicle is not a boat"));
        }
    }

    /// <summary>
    /// Represents models that represent boats
    /// </summary>
    public class BoatModel : VehicleModel
    {
        internal BoatModel(int id) : base(id) { }
    }
}
