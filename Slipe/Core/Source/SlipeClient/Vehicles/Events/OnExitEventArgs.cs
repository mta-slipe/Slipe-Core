using Slipe.Client.Peds;
using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using Slipe.Shared.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Vehicles.Events
{
    public class OnExitEventArgs
    {
        /// <summary>
        /// The player
        /// </summary>
        public Player Player { get; }

        /// <summary>
        /// The seat
        /// </summary>
        public Seat Seat { get; }

        internal OnExitEventArgs(MtaElement player, dynamic seat)
        {
            Player = ElementManager.Instance.GetElement<Player>(player);
            Seat = (Seat)seat;
        }
    }
}
