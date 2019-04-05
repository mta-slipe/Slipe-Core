using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;
using Slipe.Shared.Elements;
using Slipe.Shared.Utilities;

namespace Slipe.Shared.Vehicles
{
    /// <summary>
    /// Represents a vehicle in the GTA world
    /// </summary>
    public class SharedVehicle: PhysicalElement
    {
        private Handling handling;
        private SharedSirens sirens;

        #region Color Properties
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
        #endregion

        #region Misc. Properties

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
        /// Get the vehicle handling of the current vehicle
        /// </summary>
        public Handling Handling
        {
            get
            {
                if (handling == null)
                    handling = new Handling(this);
                return handling;
            }
        }

        /// <summary>
        /// Get and set the override-lights setting
        /// </summary>
        public OverrideLightState OverrideLights
        {
            get
            {
                return (OverrideLightState)MTAShared.GetVehicleOverrideLights(element);
            }
            set
            {
                MTAShared.SetVehicleOverrideLights(element, (int)value);
            }
        }

        /// <summary>
        /// Get and set the paintjob
        /// </summary>
        public Paintjob Paintjob
        {
            get
            {
                return (Paintjob)MTAShared.GetVehiclePaintjob(element);
            }
            set
            {
                MTAShared.SetVehiclePaintjob(element, (int)value);
            }
        }

        /// <summary>
        /// Get and set the numberplate text
        /// </summary>
        public string PlateText
        {
            get
            {
                return MTAShared.GetVehiclePlateText(element);
            }
            set
            {
                MTAShared.SetVehiclePlateText(element, value);
            }
        }

        /// <summary>
        /// The sirens of this vehicle
        /// </summary>
        public SharedSirens Sirens
        {
            get
            {
                if (sirens == null)
                    sirens = new SharedSirens(this);
                return sirens;
            }
        }

        /// <summary>
        /// Get a string representation of the type of this vehicle
        /// </summary>
        public string VehicleType
        {
            get
            {
                return MTAShared.GetVehicleType(element);
            }
        }

        /// <summary>
        /// Get a dictionary with the ugprades of upgraded slots
        /// </summary>
        public Dictionary<UpgradeSlot, Upgrade> Upgrades
        {
            get
            {
                Dictionary<int, int> d = (Dictionary<int, int>)MTAShared.GetDictionaryFromTable(MTAShared.GetVehicleUpgrades(element), "System.Int32", "System.Int32");
                Dictionary<UpgradeSlot, Upgrade> r = new Dictionary<UpgradeSlot, Upgrade>();
                foreach (KeyValuePair<int, int> upgrade in d)
                {
                    r.Add((UpgradeSlot)upgrade.Key, (Upgrade)upgrade.Value);
                }
                return r;
            }
        }

        /// <summary>
        /// Get if this vehicle is blown up
        /// </summary>
        public bool IsBlown
        {
            get
            {
                return MTAShared.IsVehicleBlown(element);
            }
        }

        /// <summary>
        /// Makes a vehicle damage proof, so it won't take damage from bullets, hits, explosions or fire. A damage proof's vehicle health can still be changed via script.
        /// </summary>
        public bool DamageProof
        {
            get
            {
                return MTAShared.IsVehicleDamageProof(element);
            }
            set
            {
                MTAShared.SetVehicleDamageProof(element, value);
            }
        }

        /// <summary>
        /// Get and set if the fuel tank is explodable
        /// </summary>
        public bool FuelTankExplodable
        {
            get
            {
                return MTAShared.IsVehicleFuelTankExplodable(element);
            }
            set
            {
                MTAShared.SetVehicleFuelTankExplodable(element, value);
            }
        }

        /// <summary>
        /// Get and set if the vehicle is locked
        /// </summary>
        public bool Locked
        {
            get
            {
                return MTAShared.IsVehicleLocked(element);
            }
            set
            {
                MTAShared.SetVehicleLocked(element, value);
            }
        }

        /// <summary>
        /// Get if the vehicle is touching the ground
        /// </summary>
        public bool IsOnGround
        {
            get
            {
                return MTAShared.IsVehicleOnGround(element);
            }
        }

        /// <summary>
        /// This function makes a vehicle's doors undamageable, so they won't fall off when they're hit.
        /// </summary>
        public bool DoorsUndamagable
        {
            set
            {
                MTAShared.SetVehicleDoorsUndamageable(element, value);
            }
        }

        /// <summary>
        /// Get the integers reprsenting the current variant. Check wiki for more info
        /// </summary>
        public Tuple<int, int> Variant
        {
            get
            {
                return MTAShared.GetVehicleVariant(element);
            }
        }

        /// <summary>
        /// Get and set the state of all wheels (front left, rear left, front right, rear right)
        /// </summary>
        public Tuple<WheelState, WheelState, WheelState, WheelState> WheelState
        {
            get
            {
                Tuple<int, int, int, int> states = MTAShared.GetVehicleWheelStates(element);
                return new Tuple<WheelState, WheelState, WheelState, WheelState>((WheelState)states.Item1, (WheelState)states.Item2, (WheelState)states.Item3, (WheelState)states.Item4);
            }
            set
            {
                MTAShared.SetVehicleWheelStates(element, (int)value.Item1, (int)value.Item2, (int)value.Item3, (int)value.Item4);
            }
        }

        /// <summary>
        /// Get the vehicle (trailer or regular vehicle) being towed by this vehicle
        /// </summary>
        public SharedVehicle VehicleTowedByThis
        {
            get
            {
                return (SharedVehicle)ElementManager.Instance.GetElement(MTAShared.GetVehicleTowedByVehicle(element));
            }
        }

        #endregion

        #region Constructors
        /// <summary>
        /// Creates or retrieves a vehicle from an MTA vehicle element
        /// </summary>
        public SharedVehicle(MTAElement element): base(element)
        {

        }

        /// <summary>
        /// Creates a vehicle from all MTA createVehicle variables
        /// </summary>
        public SharedVehicle(SharedVehicleModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1)
        {
            element = MTAShared.CreateVehicle(model.ID, position.X, position.Y, position.Z, rotation.X, rotation.Y, rotation.Z, numberplate, false, variant1, variant2);
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Creates a specific model at a certain position
        /// </summary>
        public SharedVehicle(SharedVehicleModel model, Vector3 position): this(model, position, Vector3.Zero)
        {
        }
        #endregion

        #region Misc. Methods
        /// <summary>
        /// This function will set a vehicle's health to full and fix its damage model. If you wish to only change the vehicle's health, without affecting its damage model, use Health.
        /// </summary>
        public bool Fix()
        {
            return MTAShared.FixVehicle(element);
        }

        /// <summary>
        /// Detach a towed vehicle if any
        /// </summary>
        public bool DetachTowedVehicle(SharedVehicle attachedVehicle)
        {
            return MTAShared.DetachTrailerFromVehicle(element, attachedVehicle.MTAElement);
        }

        /// <summary>
        /// Detach all vehicles that are towed by this vehicle
        /// </summary>
        public bool DetachAnyTowedVehicle()
        {
            return MTAShared.DetachTrailerFromVehicle(element, null);
        }
        #endregion

        #region Upgrade Methods
        /// <summary>
        /// Adds a vehicle upgrade to this vehicle
        /// </summary>
        public bool AddUpgrade(Upgrade upgrade)
        {
            return MTAShared.AddVehicleUpgrade(element, (int)upgrade);
        }

        /// <summary>
        /// Get compatible upgrades for a specific upgrade slot
        /// </summary>
        public Upgrade[] GetCompatibleUpgrades(UpgradeSlot slot)
        {
            int[] upInts = MTAShared.GetArrayFromTable(MTAShared.GetVehicleCompatibleUpgrades(element, (int)slot), "System.Int32");
            Upgrade[] upgrades = new Upgrade[upInts.Length];
            for (int i = 0; i < upInts.Length; i++)
            {
                upgrades[i] = (Upgrade)upInts[i];
            }
            return upgrades;
        }

        /// <summary>
        /// Get all compatible upgrades for this vehicle
        /// </summary>
        /// <returns></returns>
        public Upgrade[] GetCompatibleUpgrades()
        {
            int[] upInts = MTAShared.GetArrayFromTable(MTAShared.GetVehicleCompatibleUpgrades(element, -1), "System.Int32");
            Upgrade[] upgrades = new Upgrade[upInts.Length];
            for (int i = 0; i < upInts.Length; i++)
            {
                upgrades[i] = (Upgrade)upInts[i];
            }
            return upgrades;
        }

        /// <summary>
        /// This function returns the current upgrade id on the vehicle's 'upgrade slot' 
        /// </summary>
        public Upgrade GetUpgradeOnSlot(UpgradeSlot slot)
        {
            return (Upgrade)MTAShared.GetVehicleUpgradeOnSlot(element, (int)slot);
        }

        /// <summary>
        /// This function removes an already existing upgrade from the specified vehicle, eg: nos, hydraulics.
        /// </summary>
        public bool RemoveUpgrade(Upgrade upgrade)
        {
            return MTAShared.RemoveVehicleUpgrade(element, (int)upgrade);
        }

        #endregion

        #region Door Methods

        /// <summary>
        /// This function tells you how open a door is (the 'open ratio').
        /// </summary>
        public float GetDoorOpenRatio(Door door)
        {
            return MTAShared.GetVehicleDoorOpenRatio(element, (int)door);
        }

        /// <summary>
        /// This function sets how much a vehicle's door is open.
        /// </summary>
        public bool SetDoorOpenRatio(Door door, float ratio, int time = 0)
        {
            return MTAShared.SetVehicleDoorOpenRatio(element, (int)door, ratio, time);
        }

        /// <summary>
        /// This function returns the current state of the specifed door on this vehicle.
        /// </summary>
        public DoorState GetDoorState(Door door)
        {
            return (DoorState)MTAShared.GetVehicleDoorState(element, (int)door);
        }

        /// <summary>
        /// This function sets the state of the specified door on the vehicle.
        /// </summary>
        public bool SetDoorState(Door door, DoorState state)
        {
            return MTAShared.SetVehicleDoorState(element, (int)door, (int)state);
        }

        #endregion

        #region Light Methods
        /// <summary>
        /// This function returns the current state of the specifed light on this vehicle.
        /// </summary>
        public LightState GetLightState(Light light)
        {
            return (LightState)MTAShared.GetVehicleLightState(element, (int)light);
        }

        /// <summary>
        /// This function sets the state of the specified light on the vehicle.
        /// </summary>
        public bool SetLightState(Light light, LightState state)
        {
            return MTAShared.SetVehicleLightState(element, (int)light, (int)state);
        }
        #endregion

        #region Damage Methods
        /// <summary>
        /// Get the damage status of a particular vehicle panel
        /// </summary>
        public DamageLevel GetPanelDamage(Panel panel)
        {
            return (DamageLevel)MTAShared.GetVehiclePanelState(element, (int)panel);
        }

        /// <summary>
        /// Set the damage status of a particular vehicle panel
        /// </summary>
        public bool SetPanelDamage(Panel panel, DamageLevel damage)
        {
            return MTAShared.SetVehiclePanelState(element, (int)panel, (int)damage);
        }
        #endregion            

    }
}
