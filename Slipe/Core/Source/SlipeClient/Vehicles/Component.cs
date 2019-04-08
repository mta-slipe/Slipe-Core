using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Numerics;

namespace Slipe.Client.Vehicles
{
    /// <summary>
    /// Represents a component of a vehicle
    /// </summary>
    public class Component
    {
        private Vehicle vehicle;
        private string component;

        #region Properties
        /// <summary>
        /// Get and set the position relative to the specified component base
        /// </summary>
        public Vector3 Position
        {
            get
            {
                Tuple<float, float, float> r = MtaClient.GetVehicleComponentPosition(vehicle.MTAElement, component, Base.ToString().ToLower());
                return new Vector3(r.Item1, r.Item2, r.Item3);
            }
            set
            {
                MtaClient.SetVehicleComponentPosition(vehicle.MTAElement, component, value.X, value.Y, value.Z, Base.ToString().ToLower());
            }
        }

        /// <summary>
        /// Get and set the rotation relative to the specified component base
        /// </summary>
        public Vector3 Rotation
        {
            get
            {
                Tuple<float, float, float> r = MtaClient.GetVehicleComponentRotation(vehicle.MTAElement, component, Base.ToString().ToLower());
                return new Vector3(r.Item1, r.Item2, r.Item3);
            }
            set
            {
                MtaClient.SetVehicleComponentRotation(vehicle.MTAElement, component, value.X, value.Y, value.Z, Base.ToString().ToLower());
            }
        }

        /// <summary>
        /// Get and set if this component is visible
        /// </summary>
        public bool Visible
        {
            get
            {
                return MtaClient.GetVehicleComponentVisible(vehicle.MTAElement, component);
            }
            set
            {
                MtaClient.SetVehicleComponentVisible(vehicle.MTAElement, component, value);
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Create a component instance from a vehicle
        /// </summary>
        public Component(Vehicle vehicle, ComponentType type, ComponentBase relativeBase = ComponentBase.root)
        {
            this.vehicle = vehicle;
            this.component = type.ToString().ToLower();
            Base = relativeBase;
        }

        /// <summary>
        /// Create a component instance from a vehicle using a string as type
        /// </summary>
        public Component(Vehicle vehicle, string type, ComponentBase relativeBase = ComponentBase.root)
        {
            this.vehicle = vehicle;
            this.component = type;
            Base = relativeBase;
        }

        /// <summary>
        /// Set the base to which the position and rotation are relative
        /// </summary>
        public ComponentBase Base { get; set; }

        #endregion

        #region Methods
        /// <summary>
        /// This function reset to default component position for vehicle.
        /// </summary>
        public bool ResetPosition()
        {
            return MtaClient.ResetVehicleComponentPosition(vehicle.MTAElement, component);
        }

        /// <summary>
        /// This function reset to default component rotation for vehicle.
        /// </summary>
        public bool ResetRotation()
        {
            return MtaClient.ResetVehicleComponentRotation(vehicle.MTAElement, component);
        }

        #endregion
    }
}
