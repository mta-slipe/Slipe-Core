using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;
using Slipe.Shared.Vehicles;
using Slipe.Shared.Utilities;

namespace Slipe.Server.Vehicles
{
    /// <summary>
    /// Represents the set of all sirens on a vehicle
    /// </summary>
    public class Sirens : SharedSirens
    {
        private bool initialized;
        private int count;

        #region Properties
        /// <summary>
        /// Get the type of this siren set
        /// </summary>
        public new SirenType Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                Reinitialize();
            }
        }

        /// <summary>
        /// Visible from all directions (applies to single type only)
        /// </summary>
        public new bool VisibleFromAllDirections
        {
            get
            {
                return visibleFromAllDirection;
            }
            set
            {
                visibleFromAllDirection = value;
                Reinitialize();
            }
        }

        /// <summary>
        /// Check line of sight between camera and light so it won't draw if blocked
        /// </summary>
        public new bool CheckLineOfSight
        {
            get
            {
                return checkLOS;
            }
            set
            {
                checkLOS = value;
                Reinitialize();
            }
        }

        /// <summary>
        /// Randomise the light order, false for sequential
        /// </summary>
        public new bool UseRandomiser
        {
            get
            {
                return useRandomiser;
            }
            set
            {
                useRandomiser = value;
                Reinitialize();
            }
        }

        /// <summary>
        /// If the silent is silent (no audio) or not
        /// </summary>
        public new bool Silent
        {
            get
            {
                return silent;
            }
            set
            {
                silent = value;
                Reinitialize();
            }
        }

        /// <summary>
        /// Get and set if the sirens are on
        /// </summary>
        public new bool On
        {
            get
            {
                return MTAShared.GetVehicleSirensOn(vehicle.MTAElement);
            }
            set
            {
                // This is due to an MTA bug not turning on silent sirens that are off
                MTAShared.SetVehicleSirensOn(vehicle.MTAElement, false);
                MTAShared.SetVehicleSirensOn(vehicle.MTAElement, value);
            }
        }
        #endregion

        /// <summary>
        /// Create a sirens set attached to a vehicle
        /// </summary>
        public Sirens(SharedVehicle vehicle) : base(vehicle)
        {
            type = SirenType.dual;
            checkLOS = true;
            useRandomiser = false;
            initialized = false;
            count = 1;
        }

        /// <summary>
        /// Add an individual siren point, returns false if the maximum amount of sirens is reached
        /// </summary>
        public bool Add(Vector3 position, Color color, float minAlpha)
        {
            if(!initialized)
                Reinitialize();

            if (count < 8)
            {
                new Siren(vehicle, count, position, color, minAlpha);
                count++;
                return true;
            }
            return false;
        }

        private bool Reinitialize()
        {
            initialized = MTAServer.AddVehicleSirens(vehicle.MTAElement, count, (int)type, visibleFromAllDirection, checkLOS, useRandomiser, silent);
            return initialized;
        }
        
    }
}
