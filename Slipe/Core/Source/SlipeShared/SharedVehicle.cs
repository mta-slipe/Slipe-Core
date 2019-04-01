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
        private VehicleHandling handling;

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

        /// <summary>
        /// Adds a vehicle upgrade to this vehicle
        /// </summary>
        public bool AddUpgrade(VehicleUpgrade upgrade)
        {
            return MTAShared.AddVehicleUpgrade(element, (int)upgrade);
        }

        /// <summary>
        /// This function attaches a trailer type vehicle to this vehicle.
        /// </summary>
        public bool AttachTrailer(SharedVehicle theTrailer)
        {
            return MTAShared.AttachTrailerToVehicle(element, theTrailer.MTAElement);
        }

        /// <summary>
        /// This function detaches an already attached trailer from this vehicle.
        /// </summary>
        public bool DetachTrailer(SharedVehicle theTrailer)
        {
            return MTAShared.DetachTrailerFromVehicle(element, theTrailer.MTAElement);
        }

        /// <summary>
        /// This function detaches any already attached trailer from this vehicle.
        /// </summary>
        public bool DetachTrailer()
        {
            return MTAShared.DetachTrailerFromVehicle(element, null);
        }

        /// <summary>
        /// This function will set a vehicle's health to full and fix its damage model. If you wish to only change the vehicle's health, without affecting its damage model, use Health.
        /// </summary>
        public bool Fix()
        {
            return MTAShared.FixVehicle(element);
        }

        /// <summary>
        /// Get the vehicle handling of the current vehicle
        /// </summary>
        public VehicleHandling Handling
        {
            get
            {
                if (handling == null)
                    handling = new VehicleHandling(this);
                return handling;
            }
        }
    }
}
