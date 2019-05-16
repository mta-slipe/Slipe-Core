using Slipe.Client.Vehicles;
using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using Slipe.Shared.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Peds.Events
{
    public class OnVehicleExitEventArgs
    {
        /// <summary>
        /// The vehicle that is exited
        /// </summary>
        public BaseVehicle Vehicle { get; }

        /// <summary>
        /// The seat that is exited
        /// </summary>
        public Seat Seat { get; }

        internal OnVehicleExitEventArgs(MtaElement vehicle, dynamic seat)
        {
            Vehicle = ElementManager.Instance.GetElement<BaseVehicle>(vehicle);
            Seat = (Seat)seat;
        }
    }
}
