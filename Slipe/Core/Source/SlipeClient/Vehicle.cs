using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;
using Slipe.Shared;
using Slipe.Shared.Enums;

namespace Slipe.Client
{
    /// <summary>
    /// Class that represents vehicles in the world
    /// </summary>
    public class Vehicle : SharedVehicle
    {
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

        /// <summary>
        /// Blow up this vehicle
        /// </summary>
        public bool Blow()
        {
            return MTAClient.BlowVehicle(element);
        }

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
        /// This function gets the player sitting/trying to enter this vehicle.
        /// </summary>
        public Player GetOccupant(int seat = 0)
        {
            return (Player)ElementManager.Instance.GetElement(MTAShared.GetVehicleOccupant(element, seat));
        }

        /// <summary>
        /// Get a dictionary of players occupying this vehicle
        /// </summary>
        public Dictionary<VehicleSeat, Player> Occupants
        {
            get
            {
                Dictionary<int, MTAElement> elements = MTAShared.GetDictionaryFromTable(MTAShared.GetVehicleOccupants(element), "System.Int32", "MTAElement");
                Dictionary<VehicleSeat, Player> dictionary = new Dictionary<VehicleSeat, Player>();
                foreach (KeyValuePair<int, MTAElement> entry in elements)
                {
                    Player p = (Player)ElementManager.Instance.GetElement(entry.Value);
                    VehicleSeat s = (VehicleSeat)entry.Key;
                    dictionary.Add(s, p);
                }
                return dictionary;
            }
        }
    }
}
