using Slipe.Server.Peds;
using Slipe.Shared.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Vehicles.Events
{
    public class OnExitArgs
    {
        /// <summary>
        /// The player thate exits
        /// </summary>
        public Player Player { get; }

        /// <summary>
        /// The seat exited from
        /// </summary>
        public Seat Seat { get; }

        /// <summary>
        /// The jacker if the player is being jacked
        /// </summary>
        public Player Jacker { get; }

        /// <summary>
        /// True if the exit is forced by a script
        /// </summary>
        public bool IsForced { get; }

        internal OnExitArgs(Player player, Seat seat, Player jacker, bool forcedByScript)
        {
            Player = player;
            Seat = seat;
            Jacker = jacker;
            IsForced = forcedByScript;
        }
    }
}
