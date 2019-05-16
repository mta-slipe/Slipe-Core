using Slipe.MtaDefinitions;
using Slipe.Server.Peds;
using Slipe.Shared.Elements;
using Slipe.Shared.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Vehicles.Events
{
    public class OnEnterEventArgs
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

        internal OnEnterEventArgs(MtaElement player, dynamic seat, MtaElement jacked)
        {
            Player = ElementManager.Instance.GetElement<Player>(player);
            Seat = (Seat) seat;
            JackedPlayer = ElementManager.Instance.GetElement<Player>(jacked);
        }
    }
}
