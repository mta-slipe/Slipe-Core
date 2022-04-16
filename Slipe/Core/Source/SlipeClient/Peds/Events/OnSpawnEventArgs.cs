using SlipeLua.Client.Game;
using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SlipeLua.Client.Peds.Events
{
    public class OnSpawnEventArgs
    {
        /// <summary>
        /// The team in which this player spawned
        /// </summary>
        public Team Team { get; }

        internal OnSpawnEventArgs(MtaElement team)
        {
            Team = ElementManager.Instance.GetElement<Team>(team);
        }
    }
}
