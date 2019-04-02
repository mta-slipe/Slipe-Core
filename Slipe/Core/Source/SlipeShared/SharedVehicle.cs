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
        /// Get the original handling of a specific model
        /// </summary>
        // TODO: This throws a CSharp.lua bug. Find out why
        //public static VehicleHandling GetOriginalHandling(VehicleModel model)
        //{
        //    return new VehicleHandling(MTAShared.GetDictionaryFromTable(MTAShared.GetOriginalHandling((int)model), "System.String", "System.Dynamic"));
        //}

        /// <summary>
        /// Get and set the primary color of this vehicle
        /// </summary>
        public Color PrimaryColor
        {
            get
            {
                Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int>> r = MTAShared.GetVehicleColor(element, true);
                return new Color((byte)r.Item1, (byte)r.Item2, (byte)r.Item3);
            }
            set
            {
                MTAShared.SetVehicleColor(element, value.R, value.G, value.B, SecondaryColor.R, SecondaryColor.G, SecondaryColor.B, -1, -1, -1, -1, -1, -1);
            }
        }

        /// <summary>
        /// Get and set the secondary color of this vehicle
        /// </summary>
        public Color SecondaryColor
        {
            get
            {
                Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int>> r = MTAShared.GetVehicleColor(element, true);
                return new Color((byte)r.Item3, (byte)r.Item5, (byte)r.Item6);
            }
            set
            {
                MTAShared.SetVehicleColor(element, PrimaryColor.R, PrimaryColor.G, PrimaryColor.B, value.R, value.G, value.B, -1, -1, -1, -1, -1, -1);
            }
        }

        /// <summary>
        /// Get and set all the colors of this vehicle
        /// </summary>
        public Color[] Colors
        {
            get
            {
                Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int>> r = MTAShared.GetVehicleColor(element, true);
                Color[] c = new Color[4];
                c[0] = new Color((byte)r.Item1, (byte)r.Item2, (byte)r.Item3);
                c[1] = new Color((byte)r.Item4, (byte)r.Item5, (byte)r.Item6);
                c[2] = new Color((byte)r.Item7, (byte)r.Rest.Item1, (byte)r.Rest.Item2);
                c[3] = new Color((byte)r.Rest.Item3, (byte)r.Rest.Item4, (byte)r.Rest.Item5);
                return c;
            }
            set
            {

                MTAShared.SetVehicleColor(element, value[0].R, value[0].G, value[0].B, value[1].R, value[1].G, value[1].B, value[2].R, value[2].G, value[2].B, value[3].R, value[3].G, value[3].B);
            }
        }

        /// <summary>
        /// Get and set the headlight color of this vehicle
        /// </summary>
        public Color HeadLightColor
        {
            get
            {
                Tuple<int, int, int> r = MTAShared.GetVehicleHeadLightColor(element);
                return new Color((byte)r.Item1, (byte)r.Item2, (byte)r.Item3);
            }
            set
            {
                MTAShared.SetVehicleHeadLightColor(element, value.R, value.G, value.B);
            }
        }

        /// <summary>
        /// Get compatible upgrades for a specific upgrade slot
        /// </summary>
        public VehicleUpgrade[] GetCompatibleUpgrades(int slot)
        {
            int[] upInts = MTAShared.GetArrayFromTable(MTAShared.GetVehicleCompatibleUpgrades(element, slot), "System.Int32");
            VehicleUpgrade[] upgrades = new VehicleUpgrade[upInts.Length];
            for (int i = 0; i < upInts.Length; i++)
            {
                upgrades[i] = (VehicleUpgrade)upInts[i];
            }
            return upgrades;
        }

        /// <summary>
        /// Get all compatible upgrades for this vehicle
        /// </summary>
        /// <returns></returns>
        public VehicleUpgrade[] GetCompatibleUpgrades()
        {
            int[] upInts = MTAShared.GetArrayFromTable(MTAShared.GetVehicleCompatibleUpgrades(element, -1), "System.Int32");
            VehicleUpgrade[] upgrades = new VehicleUpgrade[upInts.Length];
            for (int i = 0; i < upInts.Length; i++)
            {
                upgrades[i] = (VehicleUpgrade)upInts[i];
            }
            return upgrades;
        }

        /// <summary>
        /// This function tells you how open a door is (the 'open ratio').
        /// </summary>
        public float GetDoorOpenRatio(VehicleDoor door)
        {
            return MTAShared.GetVehicleDoorOpenRatio(element, (int)door);
        }

        /// <summary>
        /// This function sets how much a vehicle's door is open.
        /// </summary>
        public bool SetDoorOpenRatio(VehicleDoor door, float ratio, int time = 0)
        {
            return MTAShared.SetVehicleDoorOpenRatio(element, (int)door, ratio, time);
        }

        /// <summary>
        /// This function returns the current state of the specifed door on this vehicle.
        /// </summary>
        public VehicleDoorState GetDoorState(VehicleDoor door)
        {
            return (VehicleDoorState) MTAShared.GetVehicleDoorState(element, (int)door);
        }

        /// <summary>
        /// This function sets the state of the specified door on the vehicle.
        /// </summary>
        public bool SetDoorState(VehicleDoor door, VehicleDoorState state)
        {
            return MTAShared.SetVehicleDoorState(element, (int)door, (int)state);
        }

        /// <summary>
        /// This function returns the current state of the specifed light on this vehicle.
        /// </summary>
        public VehicleLightState GetLightState(VehicleLight light)
        {
            return (VehicleLightState)MTAShared.GetVehicleLightState(element, (int)light);
        }

        /// <summary>
        /// This function sets the state of the specified light on the vehicle.
        /// </summary>
        public bool SetLightState(VehicleLight light, VehicleLightState state)
        {
            return MTAShared.SetVehicleLightState(element, (int)light, (int)state);
        }

        /// <summary>
        /// Get the max amount of passengers this vehicle can have (excluding driver seat)
        /// </summary>
        public int MaxPassengers
        {
            get
            {
                return MTAShared.GetVehicleMaxPassengers(element);
            }
        }

        /// <summary>
        /// This function retrieves the model ID of a vehicle from its name.
        /// </summary>
        public static VehicleModel GetModelFromName(string name)
        {
            return (VehicleModel)MTAShared.GetVehicleModelFromName(name);
        }

        /// <summary>
        /// Get the name of a certain model
        /// </summary>
        public static string GetNameFromModel(VehicleModel model)
        {
            return MTAShared.GetVehicleNameFromModel((int)model);
        }

        /// <summary>
        /// Get and set if the engine of this vehicle is running
        /// </summary>
        public bool EngineRunning
        {
            get
            {
                return MTAShared.GetVehicleEngineState(element);
            }
            set
            {
                MTAShared.SetVehicleEngineState(element, value);
            }
        }

        /// <summary>
        /// Get the name of this vehicle
        /// </summary>
        public string Name
        {
            get
            {
                return MTAShared.GetVehicleName(element);
            }
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
