using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;
using System.ComponentModel;

namespace Slipe.Client.Vehicles
{
    /// <summary>
    /// Represents a taxi vehicle
    /// </summary>
    public class Taxi : Vehicle
    {
        /// <summary>
        /// Get and set if the taxi light on in a taxi
        /// </summary>
        public bool TaxiLightOn
        {
            get
            {
                return MTAShared.IsVehicleTaxiLightOn(element);
            }
            set
            {
                MTAShared.SetVehicleTaxiLightOn(element, value);
            }
        }

        /// <summary>
        /// Create a vehicle from a model at a position
        /// </summary>
        public Taxi(TaxiModel model, Vector3 position) : base(model, position)
        {

        }

        /// <summary>
        /// Create a vehicle model using all createVehicle arguments
        /// </summary>
        public Taxi(TaxiModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1) : base(model, position, rotation, numberplate, variant1, variant2)
        {
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Taxi(MTAElement element) : base(element)
        {

        }
    }

    /// <summary>
    /// Represents a Taxi model
    /// </summary>
    public class TaxiModel : BaseVehicleModel
    {
        public static TaxiModel Cabbie { get { return new TaxiModel(438); } }
        public static TaxiModel Taxi { get { return new TaxiModel(420); } }

        protected TaxiModel(int id) : base(id) { }
    }
}
