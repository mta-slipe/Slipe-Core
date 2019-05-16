using Slipe.MtaDefinitions;
using Slipe.Server.Peds;
using Slipe.Shared.Elements;
using Slipe.Shared.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Vehicles.Events
{
    public class OnStartEnterEventArgs
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

        internal OnStartEnterEventArgs(MtaElement enteringPlayer, dynamic seat, MtaElement jacked, dynamic door)
        {
            Player = ElementManager.Instance.GetElement<Player>(enteringPlayer);
            Seat = (Seat)seat;
            JackedPlayer = ElementManager.Instance.GetElement<Player>(jacked);
            Door = (Door) door;
        }
    }
}
