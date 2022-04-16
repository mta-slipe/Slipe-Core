using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;
using System.Numerics;
using System.ComponentModel;

namespace SlipeLua.Server.Vehicles
{
    /// <summary>
    /// Represents a taxi vehicle
    /// </summary>
    public class Taxi : BaseVehicle
    {
        /// <summary>
        /// Get and set if the taxi light on in a taxi
        /// </summary>
        public bool TaxiLightOn
        {
            get
            {
                return MtaShared.IsVehicleTaxiLightOn(element);
            }
            set
            {
                MtaShared.SetVehicleTaxiLightOn(element, value);
            }
        }

        #region Constructors
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Taxi(MtaElement element) : base(element) { }

        /// <summary>
        /// Create a plane from a model at a position
        /// </summary>
        public Taxi(TaxiModel model, Vector3 position)
            : this(model, position, Vector3.Zero) { }

        /// <summary>
        /// Create a plane using all createVehicle arguments
        /// </summary>
        public Taxi(TaxiModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1)
            : base(model, position, rotation, numberplate, variant1, variant2) { }

        #endregion

        public static explicit operator Taxi(Vehicle vehicle)
        {
            if (VehicleModel.FromId(vehicle.Model) is TaxiModel)
                return new Taxi(vehicle.MTAElement);

            throw (new InvalidCastException("The vehicle is not a taxi"));
        }
    }

    /// <summary>
    /// Represents a Taxi model
    /// </summary>
    public class TaxiModel : VehicleModel
    {
        internal TaxiModel(int id) : base(id) { }
    }
}
