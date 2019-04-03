using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared;
using System.Numerics;
using Slipe.MTADefinitions;
using Slipe.Shared.Enums;

namespace Slipe.Server
{
    /// <summary>
    /// Represents the set of all sirens on a vehicle
    /// </summary>
    public class VehicleSirens : SharedVehicleSirens
    {
        private bool initialized = false;

        /// <summary>
        /// Create a sirens set attached to a vehicle
        /// </summary>
        public VehicleSirens(SharedVehicle vehicle) : base(vehicle) { }

        private bool Reinitialize()
        {
            return MTAServer.AddVehicleSirens(vehicle.MTAElement, count, (int)type, visibleFromAllDirection, checkLOS, useRandomiser, silent);
        }

        /// <summary>
        /// Add an individual siren point, returns false if the maximum amount of sirens is reached
        /// </summary>
        public bool Add(Vector3 position, Color color, float minAlpha)
        {
            if(count < 8)
            {
                count++;
                new Siren(vehicle, count, position, color, minAlpha);
                Reinitialize();
                return true;
            }
            return false;
        }

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
                if(!initialized)
                {
                    Reinitialize();
                    initialized = true;
                }

                // This is due to an MTA bug not turning on silent sirens that are off
                MTAShared.SetVehicleSirensOn(vehicle.MTAElement, false);
                MTAShared.SetVehicleSirensOn(vehicle.MTAElement, value);
            }
        }
    }
}
