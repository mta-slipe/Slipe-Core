using SlipeLua.Client.Peds;
using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Vehicles.Events
{
    public class OnEnterEventArgs
    {
        /// <summary>
        /// The player
        /// </summary>
        public Player Player { get; }

        /// <summary>
        /// The seat
        /// </summary>
        public Seat Seat { get; }

        internal OnEnterEventArgs(MtaElement player, dynamic seat)
        {
            Player = ElementManager.Instance.GetElement<Player>(player);
            Seat = (Seat)seat;
        }
    }
}
