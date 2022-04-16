using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Text;

namespace SlipeLua.Server.Vehicles
{
    /// <summary>
    /// Class representing all regular vehicle types
    /// </summary>
    [DefaultElementClass(ElementType.Vehicle)]
    public class Vehicle : BaseVehicle
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Vehicle(MtaElement element) : base(element) { }

        /// <summary>
        /// Create a vehicle from a model at a position
        /// </summary>
        public Vehicle(VehicleModel model, Vector3 position)
            : this(model, position, Vector3.Zero) { }

        /// <summary>
        /// Create a vehicle using all createVehicle arguments
        /// </summary>
        public Vehicle(VehicleModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1)
            : base(model, position, rotation, numberplate, variant1, variant2) { }
    }
}
