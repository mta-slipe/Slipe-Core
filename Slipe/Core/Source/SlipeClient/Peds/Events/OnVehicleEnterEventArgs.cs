using SlipeLua.Client.Vehicles;
using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Peds.Events
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

        internal OnVehicleEnterEventArgs(MtaElement vehicle, dynamic seat)
        {
            Vehicle = ElementManager.Instance.GetElement<BaseVehicle>(vehicle);
            Seat = (Seat) seat;
        }
    }
}
