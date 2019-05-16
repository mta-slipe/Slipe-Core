using Slipe.Server.Vehicles;
using Slipe.Shared.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnVehicleEnterArgs
    {
        /// <summary>
        /// The vehicle that is entered
        /// </summary>
        public BaseVehicle Vehicle { get; }

        /// <summary>
        /// The seat that is entered
        /// </summary>
        public Seat Seat { get; }

        /// <summary>
        /// If the vehicle is jacked, this is the victim
        /// </summary>
        public Player JackedPlayer { get; }

        internal OnVehicleEnterArgs(BaseVehicle vehicle, Seat seat, Player jacked)
        {
            Vehicle = vehicle;
            Seat = seat;
            JackedPlayer = jacked;
        }
    }
}
