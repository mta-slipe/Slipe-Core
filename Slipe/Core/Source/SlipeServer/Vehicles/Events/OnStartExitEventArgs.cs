using Slipe.MtaDefinitions;
using Slipe.Server.Peds;
using Slipe.Shared.Elements;
using Slipe.Shared.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Vehicles.Events
{
    public class OnStartExitEventArgs
    {
        /// <summary>
        /// The exiting player
        /// </summary>
        public Player Player { get; }

        /// <summary>
        /// The seat being exited from
        /// </summary>
        public Seat Seat { get; }

        /// <summary>
        /// The player that jacks
        /// </summary>
        public Player Jacker { get; }

        /// <summary>
        /// The door
        /// </summary>
        public Door Door { get; }

        internal OnStartExitEventArgs(MtaElement exiting, dynamic seat, MtaElement jacked, dynamic door)
        {
            Player = ElementManager.Instance.GetElement<Player>(exiting);
            Seat = (Seat)seat;
            Jacker = ElementManager.Instance.GetElement<Player>(jacked);
            Door = (Door)door;
        }
    }
}
