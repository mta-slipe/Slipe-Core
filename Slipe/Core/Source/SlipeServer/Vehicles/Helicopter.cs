using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MtaDefinitions;
using System.ComponentModel;

namespace Slipe.Server.Vehicles
{
    /// <summary>
    /// Represents helicopter vehicles
    /// </summary>
    public class Helicopter : BaseVehicle
    {
        #region Constructors
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Helicopter(MtaElement element) : base(element) { }

        /// <summary>
        /// Create a plane from a model at a position
        /// </summary>
        public Helicopter(HelicopterModel model, Vector3 position)
            : this(model, position, Vector3.Zero) { }

        /// <summary>
        /// Create a plane using all createVehicle arguments
        /// </summary>
        public Helicopter(HelicopterModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1)
            : base(model, position, rotation, numberplate, variant1, variant2) { }

        #endregion

        public static explicit operator Helicopter(Vehicle vehicle)
        {
            if (VehicleModel.FromId(vehicle.Model) is HelicopterModel)
                return new Helicopter(vehicle.MTAElement);

            throw (new InvalidCastException("The vehicle is not a helicopter"));
        }
    }

    /// <summary>
    /// Models that represent helicopters
    /// </summary>
    public class HelicopterModel : VehicleModel
    {
        internal HelicopterModel(int id) : base(id) { }
    }
}
