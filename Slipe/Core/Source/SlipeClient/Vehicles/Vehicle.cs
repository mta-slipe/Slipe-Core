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
    public class Vehicle : SharedVehicle
    {
        #region Misc. Properties
        /// <summary>
        /// Get the player controlling the vehicle in the drivers seat
        /// </summary>
        public Player Controler
        {
            get
            {
                return (Player)ElementManager.Instance.GetElement(MTAShared.GetVehicleController(element));
            }
        }

        /// <summary>
        /// Get a dictionary of players occupying this vehicle
        /// </summary>
        public Dictionary<Seat, Player> Occupants
        {
            get
            {
                Dictionary<int, MTAElement> elements = MTAShared.GetDictionaryFromTable(MTAShared.GetVehicleOccupants(element), "System.Int32", "MTAElement");
                Dictionary<Seat, Player> dictionary = new Dictionary<Seat, Player>();
                foreach (KeyValuePair<int, MTAElement> entry in elements)
                {
                    Player p = (Player)ElementManager.Instance.GetElement(entry.Value);
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
                return MTAClient.GetVehicleAdjustableProperty(element);
            }
            set
            {
                MTAClient.SetVehicleAdjustableProperty(element, value);
            }
        }

        /// <summary>
        /// Get an array of all the vehicle's components
        /// </summary>
        public Component[] Components
        {
            get
            {
                Dictionary<string, bool> d = MTAShared.GetDictionaryFromTable(MTAClient.GetVehicleComponents(element), "System.String", "System.Boolean");
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
                return MTAClient.GetVehicleCurrentGear(element);
            }
        }

        /// <summary>
        /// Get and set the direction in which the vehicle falls, also the cameras of any passengers will be rotated to match it.
        /// </summary>
        public Vector3 Gravity
        {
            get
            {
                Tuple<float, float, float> r = MTAClient.GetVehicleGravity(element);
                return new Vector3(r.Item1, r.Item2, r.Item3);
            }
            set
            {
                MTAClient.SetVehicleGravity(element, value.X, value.Y, value.Z);
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
        public Vehicle(BaseVehicleModel model, Vector3 position) : base(model, position)
        {

        }

        /// <summary>
        /// Create a vehicle model using all createVehicle arguments
        /// </summary>
        public Vehicle(BaseVehicleModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1) : base(model, position, rotation, numberplate, variant1, variant2)
        {
        }
        #endregion

        #region Misc. Methods
        /// <summary>
        /// Blow up this vehicle
        /// </summary>
        public bool Blow()
        {
            return MTAClient.BlowVehicle(element);
        }

        /// <summary>
        /// This function gets the player sitting/trying to enter this vehicle.
        /// </summary>
        public Player GetOccupant(Seat seat = Seat.FrontLeft)
        {
            return (Player)ElementManager.Instance.GetElement(MTAShared.GetVehicleOccupant(element, (int)seat));
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
            return MTAClient.IsVehicleWheelOnGround(element, (int)wheel);
        }

        /// <summary>
        /// Check if a window is open
        /// </summary>
        public bool isWindowOpen(Window window)
        {
            return MTAClient.IsVehicleWindowOpen(element, (int)window);
        }

        /// <summary>
        /// This function sets the vehicle window state.
        /// </summary>
        public bool SetWindowOpen(Window window, bool open)
        {
            return MTAClient.SetVehicleWindowOpen(element, (int)window, open);
        }
        #endregion

    }
}
