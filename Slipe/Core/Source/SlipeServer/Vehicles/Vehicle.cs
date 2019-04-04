using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;
using Slipe.Shared.Vehicles;
using Slipe.Shared;

namespace Slipe.Server.Vehicles
{
    /// <summary>
    /// Class that represents vehicles in the world
    /// </summary>
    public class Vehicle : SharedVehicle
    {
        private Sirens s_sirens;

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
        /// The sirens of this vehicle
        /// </summary>
        public new Sirens Sirens
        {
            get
            {
                if (s_sirens == null)
                    s_sirens = new Sirens(this);
                return s_sirens;
            }
            set
            {
                if (value == null)
                    MTAServer.RemoveVehicleSirens(element);
                s_sirens = value;
            }
        }

        /// <summary>
        /// Get and set the integers reprsenting the current variant. Check wiki for more info
        /// </summary>
        public new Tuple<int, int> Variant
        {
            get
            {
                return MTAShared.GetVehicleVariant(element);
            }
            set
            {
                MTAServer.SetVehicleVariant(element, value.Item1, value.Item2);
            }
        }
        #endregion

        #region Respawn Properties
        /// <summary>
        /// Set to true to have the vehicle respawn if it gets blown up
        /// </summary>
        public bool RespawnEnabled
        {
            set
            {
                MTAServer.ToggleVehicleRespawn(element, value);
            }
        }

        /// <summary>
        /// Set the respawn delay of this vehicle in milliseconds
        /// </summary>
        public int RespawnDelay
        {
            set
            {
                MTAServer.SetVehicleRespawnDelay(element, value);
            }
        }

        /// <summary>
        /// Get and set the respawn position
        /// </summary>
        public Vector3 RespawnPosition
        {
            get
            {
                Tuple<float, float, float> r = MTAServer.GetVehicleRespawnPosition(element);
                return new Vector3(r.Item1, r.Item2, r.Item3);
            }
            set
            {
                Vector3 rotation = RespawnRotation;
                MTAServer.SetVehicleRespawnPosition(element, value.X, value.Y, value.Z, rotation.X, rotation.Y, rotation.Z);
            }
        }

        /// <summary>
        /// Get and set the respawn rotation
        /// </summary>
        public Vector3 RespawnRotation
        {
            get
            {
                Tuple<float, float, float> r = MTAServer.GetVehicleRespawnRotation(element);
                return new Vector3(r.Item1, r.Item2, r.Item3);
            }
            set
            {
                MTAServer.SetVehicleRespawnRotation(element, value.X, value.Y, value.Z);
            }
        }

        /// <summary>
        /// Set the respawn delay in milliseconds
        /// </summary>
        public int IdleRespawnDelay
        {
            set
            {
                MTAServer.SetVehicleIdleRespawnDelay(element, value);
            }
        }
        #endregion

        #region Static Properties
        /// <summary>
        /// Get all the vehicles of a specific model in the server
        /// </summary>
        public static Vehicle[] OfModel(Model model)
        {
            MTAElement[] mtaElements = MTAShared.GetArrayFromTable(MTAServer.GetVehiclesOfType((int)model), "MTAElement");
            return ElementManager.Instance.CastArray<Vehicle>(mtaElements);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a vehicle from an MTA vehicle element 
        /// </summary>
        public Vehicle(MTAElement element): base(element)
        {

        }

        /// <summary>
        /// Create a vehicle from a model at a position
        /// </summary>
        public Vehicle(Model model, Vector3 position) : base(model, position)
        {

        }

        /// <summary>
        /// Create a vehicle model using all createVehicle arguments
        /// </summary>
        public Vehicle(Model model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1) : base(model, position, rotation, numberplate, variant1, variant2)
        {
        }

        #endregion

        #region Misc. Methods
        /// <summary>
        /// Blow up this vehicle
        /// </summary>
        public bool Blow(bool explode = true)
        {
            return MTAServer.BlowVehicle(element, explode);
        }

        /// <summary>
        /// This function gets the player sitting/trying to enter this vehicle.
        /// </summary>
        public Player GetOccupant(Seat seat = Seat.FrontLeft)
        {
            return (Player)ElementManager.Instance.GetElement(MTAShared.GetVehicleOccupant(element, (int)seat));
        }

        #endregion

        #region Respawn Methods
        /// <summary>
        /// Resets the vehicle explosion time. This is the point in time at which the vehicle last exploded: at this time plus the vehicle's respawn delay, the vehicle is respawned. You can use this function to prevent the vehicle from respawning.
        /// </summary>
        public bool ResetExplosionTime()
        {
            return MTAServer.ResetVehicleExplosionTime(element);
        }

        /// <summary>
        /// Resets the vehicle idle time
        /// </summary>
        public bool ResetIdleTime()
        {
            return MTAServer.ResetVehicleIdleTime(element);
        }

        /// <summary>
        /// Spawns the vehicle at a different position and rotation
        /// </summary>
        public bool Spawn(Vector3 position, Vector3 rotation)
        {
            return MTAServer.SpawnVehicle(element, position.X, position.Y, position.Z, rotation.X, rotation.Y, rotation.Z);
        }

        /// <summary>
        /// Spawns the vehicle at a different position
        /// </summary>
        public bool Spawn(Vector3 position)
        {
            return Spawn(position, Vector3.Zero);
        }

        /// <summary>
        /// Respawns the vehicle
        /// </summary>
        public bool Respawn()
        {
            return MTAServer.RespawnVehicle(element);
        }
        #endregion

        #region Static Methods
        /// <summary>
        /// Get the model handling of a certain vehicle model
        /// </summary>
        public static ModelHandling GetModelHandling(Model model)
        {
            return new ModelHandling(model);
        }
        #endregion

        #region Events
        /// <summary>
        /// Handles events for vehicles
        /// </summary>
        public override void HandleEvent(string eventName, MTAElement element, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8)
        {
            switch (eventName)
            {
                case "onVehicleDamage":
                    OnDamage?.Invoke((float)p1);
                    break;
            }
        }

        public delegate void OnVehicleDamageHandler(float loss);
        public event OnVehicleDamageHandler OnDamage;
        #endregion

    }
}
