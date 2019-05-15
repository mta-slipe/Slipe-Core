using Slipe.Server.Peds;
using Slipe.Shared.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Vehicles.Events
{
    public class OnEnterArgs
    {
        /// <summary>
        /// The player entering the vehicle
        /// </summary>
        public Player Player;

        /// <summary>
        /// The seat the player enters
        /// </summary>
        public Seat Seat;

        /// <summary>
        /// If the vehicle is jacked, this is the victim
        /// </summary>
        public Player JackedPlayer;

        internal OnEnterArgs(Player player, Seat seat, Player jacked)
        {
            Player = player;
            Seat = seat;
            JackedPlayer = jacked;
        }
    }
}
