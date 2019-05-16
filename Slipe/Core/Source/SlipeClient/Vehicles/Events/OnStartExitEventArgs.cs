using Slipe.Client.Peds;
using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using Slipe.Shared.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Vehicles.Events
{
    public class OnStartExitEventArgs
    {
        /// <summary>
        /// The player
        /// </summary>
        public Player Player { get; }

        /// <summary>
        /// The seat
        /// </summary>
        public Seat Seat { get; }

        /// <summary>
        /// The door that is used
        /// </summary>
        public Door Door { get; }

        internal OnStartExitEventArgs(MtaElement player, dynamic seat, dynamic door)
        {
            Player = ElementManager.Instance.GetElement<Player>(player);
            Seat = (Seat)seat;
            Door = (Door)door;
        }
    }
}
