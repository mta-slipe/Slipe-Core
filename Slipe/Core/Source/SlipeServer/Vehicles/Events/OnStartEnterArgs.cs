using Slipe.Server.Peds;
using Slipe.Shared.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Vehicles.Events
{
    public class OnStartEnterArgs
    {
        /// <summary>
        /// The entering player
        /// </summary>
        public Player Player { get; }

        /// <summary>
        /// The seat being entered to
        /// </summary>
        public Seat Seat { get; }

        /// <summary>
        /// The player that would be jacked
        /// </summary>
        public Player JackedPlayer { get; }

        /// <summary>
        /// The door
        /// </summary>
        public Door Door { get; }

        internal OnStartEnterArgs(Player enteringPlayer, Seat seat, Player jacked, Door door)
        {
            Player = enteringPlayer;
            Seat = seat;
            JackedPlayer = jacked;
            Door = door;
        }
    }
}
