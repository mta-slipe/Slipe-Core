using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Vehicles;
using System.Numerics;
using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System.ComponentModel;
using Slipe.Server.Peds;

namespace Slipe.Server.Vehicles
{
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
                return (Player)ElementManager.Instance.GetElement(MtaShared.GetVehicleController(element));
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
                    MtaServer.RemoveVehicleSirens(element);
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
                return MtaShared.GetVehicleVariant(element);
            }
            set
            {
                MtaServer.SetVehicleVariant(element, value.Item1, value.Item2);
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
                MtaServer.ToggleVehicleRespawn(element, value);
            }
        }

        /// <summary>
        /// Set the respawn delay of this vehicle in milliseconds
        /// </summary>
        public int RespawnDelay
        {
            set
            {
                MtaServer.SetVehicleRespawnDelay(element, value);
            }
        }

        /// <summary>
        /// Get and set the respawn position
        /// </summary>
        public Vector3 RespawnPosition
        {
            get
            {
                Tuple<float, float, float> r = MtaServer.GetVehicleRespawnPosition(element);
                return new Vector3(r.Item1, r.Item2, r.Item3);
            }
            set
            {
                Vector3 rotation = RespawnRotation;
                MtaServer.SetVehicleRespawnPosition(element, value.X, value.Y, value.Z, rotation.X, rotation.Y, rotation.Z);
            }
        }

        /// <summary>
        /// Get and set the respawn rotation
        /// </summary>
        public Vector3 RespawnRotation
        {
            get
            {
                Tuple<float, float, float> r = MtaServer.GetVehicleRespawnRotation(element);
                return new Vector3(r.Item1, r.Item2, r.Item3);
            }
            set
            {
                MtaServer.SetVehicleRespawnRotation(element, value.X, value.Y, value.Z);
            }
        }

        /// <summary>
        /// Set the respawn delay in milliseconds
        /// </summary>
        public int IdleRespawnDelay
        {
            set
            {
                MtaServer.SetVehicleIdleRespawnDelay(element, value);
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Create a plane from a model at a position
        /// </summary>
        public Vehicle(BaseVehicleModel model, Vector3 position) : base(model, position)
        {
            ListenForEvent("onVehicleDamage");
        }

        /// <summary>
        /// Create a plane using all createVehicle arguments
        /// </summary>
        public Vehicle(BaseVehicleModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1) : base(model, position, rotation, numberplate, variant1, variant2)
        {
            ListenForEvent("onVehicleDamage");
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Vehicle(MtaElement element) : base(element)
        {
            ListenForEvent("onVehicleDamage");
        }

        #endregion

        #region Misc. Methods
        /// <summary>
        /// Blow up this vehicle
        /// </summary>
        public bool Blow(bool explode = true)
        {
            return MtaServer.BlowVehicle(element, explode);
        }

        /// <summary>
        /// This function gets the player sitting/trying to enter this vehicle.
        /// </summary>
        public Player GetOccupant(Seat seat = Seat.FrontLeft)
        {
            return (Player)ElementManager.Instance.GetElement(MtaShared.GetVehicleOccupant(element, (int)seat));
        }

        #endregion

        #region Respawn Methods
        /// <summary>
        /// Resets the vehicle explosion time. This is the point in time at which the vehicle last exploded: at this time plus the vehicle's respawn delay, the vehicle is respawned. You can use this function to prevent the vehicle from respawning.
        /// </summary>
        public bool ResetExplosionTime()
        {
            return MtaServer.ResetVehicleExplosionTime(element);
        }

        /// <summary>
        /// Resets the vehicle idle time
        /// </summary>
        public bool ResetIdleTime()
        {
            return MtaServer.ResetVehicleIdleTime(element);
        }

        /// <summary>
        /// Spawns the vehicle at a different position and rotation
        /// </summary>
        public bool Spawn(Vector3 position, Vector3 rotation)
        {
            return MtaServer.SpawnVehicle(element, position.X, position.Y, position.Z, rotation.X, rotation.Y, rotation.Z);
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
            return MtaServer.RespawnVehicle(element);
        }
        #endregion

        #region Events
        /// <summary>
        /// Handles events for vehicles
        /// </summary>
        public override void HandleEvent(string eventName, MtaElement source, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8)
        {
            switch (eventName)
            {
                case "onVehicleDamage":
                    OnDamage?.Invoke((float)p1);
                    break;
                default:
                    base.HandleEvent(eventName, source, p1, p2, p3, p4, p5, p6, p7, p8);
                    break;
            }
        }

        public delegate void OnVehicleDamageHandler(float loss);
        public event OnVehicleDamageHandler OnDamage;
        #endregion

    }
}
