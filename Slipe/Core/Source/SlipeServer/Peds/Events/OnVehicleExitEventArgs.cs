using SlipeLua.MtaDefinitions;
using SlipeLua.Server.Vehicles;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Peds.Events
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

        /// <summary>
        /// If the vehicle is jacked, this is the jacker
        /// </summary>
        public Player Jacker { get; }

        /// <summary>
        /// True if the exit is forced by script
        /// </summary>
        public bool IsForced { get; }

        internal OnVehicleExitEventArgs(MtaElement vehicle, dynamic seat, MtaElement jacker, dynamic forcedByScript)
        {
            Vehicle = ElementManager.Instance.GetElement<BaseVehicle>(vehicle);
            Seat = (Seat)seat;
            Jacker = ElementManager.Instance.GetElement<Player>(jacker);
            IsForced = (bool) forcedByScript;
        }
    }
}
