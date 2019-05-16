using Slipe.MtaDefinitions;
using Slipe.Server.Vehicles;
using Slipe.Shared.Elements;
using Slipe.Shared.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
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
