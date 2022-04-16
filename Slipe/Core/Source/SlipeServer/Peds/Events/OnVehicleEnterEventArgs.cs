using SlipeLua.MtaDefinitions;
using SlipeLua.Server.Vehicles;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Peds.Events
{
    public class OnVehicleEnterEventArgs
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

        internal OnVehicleEnterEventArgs(MtaElement vehicle, dynamic seat, MtaElement jacked)
        {
            Vehicle = ElementManager.Instance.GetElement<BaseVehicle>(vehicle);
            Seat = (Seat) seat;
            JackedPlayer = ElementManager.Instance.GetElement<Player>(jacked);
        }
    }
}
