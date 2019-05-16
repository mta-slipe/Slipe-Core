using Slipe.Server.Vehicles;
using Slipe.Shared.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnVehicleExitArgs
    {
        /// <summary>
        /// The vehicle that is exited
        /// </summary>
        public BaseVehicle Vehicle { get; }

        /// <summary>
        /// The seat that is exited
        /// </summary>
        public Seat Seat { get; }

        /// <summary>
        /// If the vehicle is jacked, this is the jacker
        /// </summary>
        public Player Jacker { get; }

        /// <summary>
        /// True if the exit is forced by script
        /// </summary>
        public bool IsForced { get; }

        internal OnVehicleExitArgs(BaseVehicle vehicle, Seat seat, Player jacker, bool forcedByScript)
        {
            Vehicle = vehicle;
            Seat = seat;
            Jacker = jacker;
            IsForced = forcedByScript;
        }
    }
}
