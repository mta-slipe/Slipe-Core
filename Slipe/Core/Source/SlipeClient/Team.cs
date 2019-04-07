using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Elements;
using Slipe.Shared.Utilities;
using System.ComponentModel;

namespace Slipe.Client
{
    /// <summary>
    /// Class representing a team of players
    /// </summary>
    public class Team: Element
    {
        /// <summary>
        /// Get the name of the team
        /// </summary>
        public string Name { get { return MTAShared.GetTeamName(MTAElement); } }

        /// <summary>
        /// Get if friendly fire is enabled
        /// </summary>
        public bool FriendlyFire { get { return MTAShared.GetTeamFriendlyFire(MTAElement); } }

        /// <summary>
        /// Get the amount of players in this team
        /// </summary>
        public int PlayerCount { get { return MTAShared.CountPlayersInTeam(MTAElement); } }

        /// <summary>
        /// Get the color of this team
        /// </summary>
        public Color Color {
            get
            {
                Tuple<int, int, int> color = MTAShared.GetTeamColor(MTAElement);
                return new Color((byte)color.Item1, (byte)color.Item2, (byte)color.Item3);
            }
        }

        /// <summary>
        /// Get a list of all players in this team
        /// </summary>
        public Player[] Players
        {
            get
            {
                MTAElement[] mtaPlayers = MTAShared.GetArrayFromTable(MTAShared.GetPlayersInTeam(MTAElement), "element");
                return ElementManager.Instance.CastArray<Player>(mtaPlayers);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Team(MTAElement team) : base(team)
        {

        }
    }
}
