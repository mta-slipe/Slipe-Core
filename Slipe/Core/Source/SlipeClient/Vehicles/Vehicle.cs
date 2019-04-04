using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;
using Slipe.Shared.Vehicles;
using Slipe.Shared;

namespace Slipe.Client.Vehicles
{
    /// <summary>
    /// Class that represents vehicles in the world
    /// </summary>
    public class Vehicle : BaseVehicle
    {

        #region Nitro Properties

        /// <summary>
        /// Get and set the nitro count
        /// </summary>
        public int NitroCount
        {
            get
            {
                return MTAClient.GetVehicleNitroCount(element);
            }
            set
            {
                MTAClient.SetVehicleNitroCount(element, value);
            }
        }

        /// <summary>
        /// Get and set the level of nitro
        /// </summary>
        public float NitroLevel
        {
            get
            {
                return MTAClient.GetVehicleNitroLevel(element);
            }
            set
            {
                MTAClient.SetVehicleNitroLevel(element, value);
            }
        }

        /// <summary>
        /// Get and set if the nitro is currently actived
        /// </summary>
        public bool NitroActivated
        {
            get
            {
                return MTAClient.IsVehicleNitroActivated(element);
            }
            set
            {
                MTAClient.SetVehicleNitroActivated(element, value);
            }
        }

        /// <summary>
        /// Get if the vehicle nitro is recharging
        /// </summary>
        public bool IsNitroRecharging
        {
            get
            {
                return MTAClient.IsVehicleNitroRecharging(element);
            }
        }

        #endregion

        #region Constructors
        /// <summary>
        /// Create a vehicle from an MTA vehicle element 
        /// </summary>
        public Vehicle(MTAElement element) : base(element)
        {

        }

        /// <summary>
        /// Create a vehicle from a model at a position
        /// </summary>
        public Vehicle(VehicleModel model, Vector3 position) : base(model, position)
        {

        }

        /// <summary>
        /// Create a vehicle model using all createVehicle arguments
        /// </summary>
        public Vehicle(VehicleModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1) : base(model, position, rotation, numberplate, variant1, variant2)
        {
        }
        #endregion

    }
}
