using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MtaDefinitions;
using Slipe.Shared.Vehicles;
using Slipe.Shared.Elements;
using System.ComponentModel;
using Slipe.Client.Peds;
using Slipe.Shared.CollisionShapes;
using Slipe.Shared.Weapons;
using Slipe.Shared.Explosions;
using Slipe.Client.Elements.Events;
using Slipe.Shared.Elements.Events;
using Slipe.Client.Vehicles.Events;

namespace Slipe.Client.Vehicles
{
    /// <summary>
    /// Abstract class for client-side vehicles
    /// </summary>
    public class BaseVehicle : SharedVehicle
    {
        #region Misc. Properties
        /// <summary>
        /// Get the player controlling the vehicle in the drivers seat
        /// </summary>
        public Player Controler
        {
            get
            {
                return ElementManager.Instance.GetElement<Player>(MtaShared.GetVehicleController(element));
            }
        }

        /// <summary>
        /// Get a dictionary of players occupying this vehicle
        /// </summary>
        public Dictionary<Seat, Player> Occupants
        {
            get
            {
                Dictionary<int, MtaElement> elements = MtaShared.GetDictionaryFromTable(MtaShared.GetVehicleOccupants(element), "System.Int32", "MTAElement");
                Dictionary<Seat, Player> dictionary = new Dictionary<Seat, Player>();
                foreach (KeyValuePair<int, MtaElement> entry in elements)
                {
                    Player p = ElementManager.Instance.GetElement<Player>(entry.Value);
                    Seat s = (Seat)entry.Key;
                    dictionary.Add(s, p);
                }
                return dictionary;
            }
        }

        /// <summary>
        /// Get and set the adjustable property (hydra jet, dozer front etc.)
        /// </summary>
        public int AdjustableProperty
        {
            get
            {
                return MtaClient.GetVehicleAdjustableProperty(element);
            }
            set
            {
                MtaClient.SetVehicleAdjustableProperty(element, value);
            }
        }

        /// <summary>
        /// Get an array of all the vehicle's components
        /// </summary>
        public Component[] Components
        {
            get
            {
                Dictionary<string, bool> d = MtaShared.GetDictionaryFromTable(MtaClient.GetVehicleComponents(element), "System.String", "System.Boolean");
                Component[] r = new Component[d.Count];
                int count = 0;
                foreach (KeyValuePair<string, bool> c in d)
                {
                    r[count] = new Component(this, c.Key);
                    count++;
                }
                return r;
            }
        }

        /// <summary>
        /// Get the current gear of this vehicle
        /// </summary>
        public int CurrentGear
        {
            get
            {
                return MtaClient.GetVehicleCurrentGear(element);
            }
        }

        /// <summary>
        /// Get and set the direction in which the vehicle falls, also the cameras of any passengers will be rotated to match it.
        /// </summary>
        public Vector3 Gravity
        {
            get
            {
                Tuple<float, float, float> r = MtaClient.GetVehicleGravity(element);
                return new Vector3(r.Item1, r.Item2, r.Item3);
            }
            set
            {
                MtaClient.SetVehicleGravity(element, value.X, value.Y, value.Z);
            }
        }

        #endregion

        #region Nitro Properties

        /// <summary>
        /// Get and set the nitro count
        /// </summary>
        public int NitroCount
        {
            get
            {
                return MtaClient.GetVehicleNitroCount(element);
            }
            set
            {
                MtaClient.SetVehicleNitroCount(element, value);
            }
        }

        /// <summary>
        /// Get and set the level of nitro
        /// </summary>
        public float NitroLevel
        {
            get
            {
                return MtaClient.GetVehicleNitroLevel(element);
            }
            set
            {
                MtaClient.SetVehicleNitroLevel(element, value);
            }
        }

        /// <summary>
        /// Get and set if the nitro is currently actived
        /// </summary>
        public bool NitroActivated
        {
            get
            {
                return MtaClient.IsVehicleNitroActivated(element);
            }
            set
            {
                MtaClient.SetVehicleNitroActivated(element, value);
            }
        }

        /// <summary>
        /// Get if the vehicle nitro is recharging
        /// </summary>
        public bool IsNitroRecharging
        {
            get
            {
                return MtaClient.IsVehicleNitroRecharging(element);
            }
        }

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public BaseVehicle(MtaElement element) : base(element) { }

        /// <summary>
        /// Create a vehicle using all createVehicle arguments
        /// </summary>
        protected BaseVehicle(VehicleModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1)
            : this(MtaClient.CreateVehicle(model.Id, position.X, position.Y, position.Z, rotation.X, rotation.Y, rotation.Z, numberplate, variant1, variant2)) { }
        #endregion

        #region Misc. Methods
        /// <summary>
        /// Blow up this vehicle
        /// </summary>
        public bool Blow()
        {
            return MtaClient.BlowVehicle(element);
        }

        /// <summary>
        /// This function gets the player sitting/trying to enter this vehicle.
        /// </summary>
        public Player GetOccupant(Seat seat = Seat.FrontLeft)
        {
            return ElementManager.Instance.GetElement<Player>(MtaShared.GetVehicleOccupant(element, (int)seat));
        }

        /// <summary>
        /// Get a specific component of this vehicle
        /// </summary>
        public Component GetComponent(ComponentType type, ComponentBase relativeTo = ComponentBase.root)
        {
            return new Component(this, type, relativeTo);
        }

        /// <summary>
        /// Check if a wheel is touching the ground
        /// </summary>
        public bool IsWheelOnGround(Wheel wheel)
        {
            return MtaClient.IsVehicleWheelOnGround(element, (int)wheel);
        }

        /// <summary>
        /// Check if a window is open
        /// </summary>
        public bool isWindowOpen(Window window)
        {
            return MtaClient.IsVehicleWindowOpen(element, (int)window);
        }

        /// <summary>
        /// This function sets the vehicle window state.
        /// </summary>
        public bool SetWindowOpen(Window window, bool open)
        {
            return MtaClient.SetVehicleWindowOpen(element, (int)window, open);
        }
        #endregion

        #region Events

        #pragma warning disable 67

        public delegate void OnCollisionShapeHitHandler(BaseVehicle source, OnCollisionShapeHitEventArgs eventArgs);
        public event OnCollisionShapeHitHandler OnCollisionShapeHit;

        public delegate void OnCollisionShapeLeaveHandler(BaseVehicle source, OnCollisionShapeLeaveEventArgs eventArgs);
        public event OnCollisionShapeLeaveHandler OnCollisionShapeLeave;

        public delegate void OnCollisionHandler(BaseVehicle source, OnCollisionEventArgs eventArgs);
        public event OnCollisionHandler OnCollision;

        public delegate void OnDamageHandler(BaseVehicle source, OnDamageEventArgs eventArgs);
        public event OnDamageHandler OnDamage;

        public delegate void OnEnterHandler(BaseVehicle source, OnEnterEventArgs eventArgs);
        public event OnEnterHandler OnEnter;

        public delegate void OnExitHandler(BaseVehicle source, OnExitEventArgs eventArgs);
        public event OnExitHandler OnExit;

        public delegate void OnStartEnterHandler(BaseVehicle source, OnStartEnterEventArgs eventArgs);
        public event OnStartEnterHandler OnStartEnter;

        public delegate void OnStartExitHandler(BaseVehicle source, OnStartExitEventArgs eventArgs);
        public event OnStartExitHandler OnStartExit;

        public delegate void OnExplodeHandler(BaseVehicle source, OnExplodeEventArgs eventArgs);
        public event OnExplodeHandler OnExplode;

        public delegate void OnRespawnHandler(BaseVehicle source, OnRespawnEventArgs eventArgs);
        public event OnRespawnHandler OnRespawn;

        public delegate void OnNitroStateChangeHandler(BaseVehicle source, OnNitroStateChangeEventArgs eventArgs);
        public event OnNitroStateChangeHandler OnNitroStateChange;

        public delegate void OnExplosionHandler(BaseVehicle source, OnExplosionEventArgs eventArgs);
        public event OnExplosionHandler OnExplosion;

        public delegate void OnWorldSoundHandler(BaseVehicle source, OnWorldSoundEventArgs eventArgs);
        public event OnWorldSoundHandler OnWorldSound;

        public delegate void OnWeaponHitHandler(BaseVehicle source, OnWeaponHitEventArgs eventArgs);
        public event OnWeaponHitHandler OnWeaponHit;

#pragma warning restore 67

        #endregion

    }
}
