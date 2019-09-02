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
        private BaseVehicle vehicle;
        private string component;
        private string relativeBase;

        #region Properties
        /// <summary>
        /// Get and set the position relative to the specified component base
        /// </summary>
        public Vector3 Position
        {
            get
            {
                Tuple<float, float, float> r = MtaClient.GetVehicleComponentPosition(vehicle.MTAElement, component, relativeBase);
                return new Vector3(r.Item1, r.Item2, r.Item3);
            }
            set
            {
                MtaClient.SetVehicleComponentPosition(vehicle.MTAElement, component, value.X, value.Y, value.Z, relativeBase);
            }
        }

        /// <summary>
        /// Get and set the rotation relative to the specified component base
        /// </summary>
        public Vector3 Rotation
        {
            get
            {
                Tuple<float, float, float> r = MtaClient.GetVehicleComponentRotation(vehicle.MTAElement, component, relativeBase);
                return new Vector3(r.Item1, r.Item2, r.Item3);
            }
            set
            {
                MtaClient.SetVehicleComponentRotation(vehicle.MTAElement, component, value.X, value.Y, value.Z, relativeBase);
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

        /// <summary>
        /// Get and set the scale of this component
        /// </summary>
        public Vector3 Scale
        {
            get
            {
                Tuple<float, float, float> r = MtaClient.GetVehicleComponentScale(vehicle.MTAElement, component, relativeBase);
                return new Vector3(r.Item1, r.Item2, r.Item3);
            }
            set
            {
                MtaClient.SetVehicleComponentScale(vehicle.MTAElement, component, value.X, value.Y, value.Z, relativeBase);
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Create a component instance from a vehicle
        /// </summary>
        public Component(BaseVehicle vehicle, ComponentType type, ComponentBase relativeBase = ComponentBase.root)
        {
            this.vehicle = vehicle;
            this.component = type.ToString().ToLower();
            this.relativeBase = relativeBase.ToString().ToLower();
        }

        /// <summary>
        /// Create a component instance from a vehicle using a string as type
        /// </summary>
        public Component(BaseVehicle vehicle, string type, ComponentBase relativeBase = ComponentBase.root)
        {
            this.vehicle = vehicle;
            this.component = type;
            this.relativeBase = relativeBase.ToString().ToLower();
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

        public bool ResetScale()
        {
            return MtaClient.ResetVehicleComponentScale(vehicle.MTAElement, component);
        }

        #endregion
    }
}
