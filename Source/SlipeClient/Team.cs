using Slipe.Shared;
using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;

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
        public List<Player> Players
        {
            get
            {
                List<Player> players = new List<Player>();
                List<dynamic> mtaPlayers = MTAShared.GetListFromTable(MTAShared.GetPlayersInTeam(MTAElement));
                foreach (dynamic player in mtaPlayers)
                {
                    players.Add((Player)ElementManager.Instance.GetElement((MTAElement)player));
                }
                return players;
            }
        }

        /// <summary>
        /// Create a team from an MTA team element
        /// </summary>
        /// <param name="team"></param>
        public Team(MTAElement team) : base(team)
        {

        }
    }
}
