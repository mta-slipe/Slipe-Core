using Slipe.Server.Peds;
using Slipe.Shared.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Vehicles.Events
{
    public class OnStartExitArgs
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

        internal OnStartExitArgs(Player exiting, Seat seat, Player jacked, Door door)
        {
            Player = exiting;
            Seat = seat;
            Jacker = jacked;
            Door = door;
        }
    }
}
