using Slipe.Shared;
using Slipe.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;
using Slipe.Server.Enums;

namespace Slipe.Server
{
    /// <summary>
    /// Class that represents vehicles in the world
    /// </summary>
    public class Vehicle : SharedVehicle
    {
        /// <summary>
        /// Create a vehicle from an MTA vehicle element 
        /// </summary>
        public Vehicle(MTAElement element): base(element)
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

        /// <summary>
        /// Add sirens to this vehicle
        /// </summary>
        public bool AddSirens(int sirenCount, Siren sirenType, bool threesixtyflag = false, bool checkLOSFlag = true, bool useRandomizer = true, bool silentFlag = false)
        {
            return MTAServer.AddVehicleSirens(element, sirenCount, (int)sirenType, threesixtyflag, checkLOSFlag, useRandomizer, silentFlag);
        }

        /// <summary>
        /// Blow up this vehicle
        /// </summary>
        public bool Blow(bool explode = true)
        {
            return MTAServer.BlowVehicle(element, explode);
        }

        /// <summary>
        /// Handles events for vehicles
        /// </summary>
        public override void HandleEvent(string eventName, MTAElement element, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8)
        {
            switch (eventName)
            {
                case "onVehicleDamage":
                    OnDamage?.Invoke((float) p1);
                    break;
            }
        }

        public delegate void OnVehicleDamageHandler(float loss);
        public event OnVehicleDamageHandler OnDamage;
    }
}
