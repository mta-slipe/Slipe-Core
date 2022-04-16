using SlipeLua.MtaDefinitions;
using SlipeLua.Server.Peds;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Vehicles.Events
{
    public class OnExitEventArgs
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

        internal OnExitEventArgs(MtaElement player, dynamic seat, MtaElement jacker, dynamic forcedByScript)
        {
            Player = ElementManager.Instance.GetElement<Player>(player);
            Seat = (Seat)seat;
            Jacker = ElementManager.Instance.GetElement<Player>(jacker);
            IsForced = (bool) forcedByScript;
        }
    }
}
