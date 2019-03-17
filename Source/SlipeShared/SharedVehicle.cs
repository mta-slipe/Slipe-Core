using Slipe.Shared.Enums;
using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Slipe.Shared
{
    /// <summary>
    /// Represents a vehicle in the GTA world
    /// </summary>
    public class SharedVehicle: PhysicalElement
    {
    
        /// <summary>
        /// Creates or retrieves a vehicle from an MTA vehicle element
        /// </summary>
        public SharedVehicle(MTAElement element): base(element)
        {

        }

        /// <summary>
        /// Creates a vehicle from all MTA createVehicle variables
        /// </summary>
        public SharedVehicle(VehicleModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1)
        {
            element = MTAShared.CreateVehicle((int)model, position.X, position.Y, position.Z, rotation.X, rotation.Y, rotation.Z, numberplate, false, variant1, variant2);
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Creates a specific model at a certain position
        /// </summary>
        public SharedVehicle(VehicleModel model, Vector3 position): this(model, position, Vector3.Zero)
        {
        }
    }
}
