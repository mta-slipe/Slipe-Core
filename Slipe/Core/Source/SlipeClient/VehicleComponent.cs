using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;
using Slipe.Client.Enums;

namespace Slipe.Client
{
    /// <summary>
    /// Represents a component of a vehicle
    /// </summary>
    public class VehicleComponent
    {
        private Vehicle vehicle;
        private string component;

        /// <summary>
        /// Create a component instance from a vehicle
        /// </summary>
        public VehicleComponent(Vehicle vehicle, ComponentType type, ComponentBase relativeBase = ComponentBase.root)
        {
            this.vehicle = vehicle;
            this.component = type.ToString().ToLower();
            Base = relativeBase;
        }

        /// <summary>
        /// Create a component instance from a vehicle using a string as type
        /// </summary>
        public VehicleComponent(Vehicle vehicle, string type, ComponentBase relativeBase = ComponentBase.root)
        {
            this.vehicle = vehicle;
            this.component = type;
            Base = relativeBase;
        }

        /// <summary>
        /// Set the base to which the position and rotation are relative
        /// </summary>
        public ComponentBase Base { get; set; }

        /// <summary>
        /// Get and set the position relative to the specified component base
        /// </summary>
        public Vector3 Position
        {
            get
            {
                Tuple<float, float, float> r = MTAClient.GetVehicleComponentPosition(vehicle.MTAElement, component, Base.ToString().ToLower());
                return new Vector3(r.Item1, r.Item2, r.Item3);
            }
            set
            {
                MTAClient.SetVehicleComponentPosition(vehicle.MTAElement, component, value.X, value.Y, value.Z, Base.ToString().ToLower());
            }
        }

        /// <summary>
        /// Get and set the rotation relative to the specified component base
        /// </summary>
        public Vector3 Rotation
        {
            get
            {
                Tuple<float, float, float> r = MTAClient.GetVehicleComponentRotation(vehicle.MTAElement, component, Base.ToString().ToLower());
                return new Vector3(r.Item1, r.Item2, r.Item3);
            }
            set
            {
                MTAClient.SetVehicleComponentRotation(vehicle.MTAElement, component, value.X, value.Y, value.Z, Base.ToString().ToLower());
            }
        }

        /// <summary>
        /// This function reset to default component position for vehicle.
        /// </summary>
        public bool ResetPosition()
        {
            return MTAClient.ResetVehicleComponentPosition(vehicle.MTAElement, component);
        }

        /// <summary>
        /// This function reset to default component rotation for vehicle.
        /// </summary>
        public bool ResetRotation()
        {
            return MTAClient.ResetVehicleComponentRotation(vehicle.MTAElement, component);
        }

        /// <summary>
        /// Get and set if this component is visible
        /// </summary>
        public bool Visible
        {
            get
            {
                return MTAClient.GetVehicleComponentVisible(vehicle.MTAElement, component);
            }
            set
            {
                MTAClient.SetVehicleComponentVisible(vehicle.MTAElement, component, value);
            }
        }
    }
}
