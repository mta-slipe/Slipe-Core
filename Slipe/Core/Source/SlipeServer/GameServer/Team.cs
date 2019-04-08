using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Elements;
using Slipe.Shared.Utilities;
using System.ComponentModel;
using Slipe.Server.Peds;

namespace Slipe.Server.GameServer
{
    /// <summary>
    /// Class representing a team of players
    /// </summary>
    public class Team : Element
    {
        #region Properties

        /// <summary>
        /// Get the amount of players on this team
        /// </summary>
        public int PlayerCount { get { return MTAShared.CountPlayersInTeam(MTAElement); } }

        /// <summary>
        /// Get and set the name of this team
        /// </summary>
        public string Name
        {
            get
            {
                return MTAShared.GetTeamName(MTAElement);
            }
            set
            {
                MTAServer.SetTeamName(MTAElement, value);
            }
        }

        /// <summary>
        /// Get and set the friendly fire property of this team
        /// </summary>
        public bool FriendlyFire
        {
            get
            {
                return MTAShared.GetTeamFriendlyFire(MTAElement);
            }
            set
            {
                MTAServer.SetTeamFriendlyFire(MTAElement, value);
            }
        }

        /// <summary>
        /// Get and set the team color
        /// </summary>
        public Color Color
        {
            get
            {
                Tuple<int, int, int> color = MTAShared.GetTeamColor(MTAElement);
                return new Color((byte)color.Item1, (byte)color.Item2, (byte)color.Item3);
            }
            set
            {
                MTAServer.SetTeamColor(MTAElement, value.R, value.G, value.B);
            }
        }

        /// <summary>
        /// Get a list of players on this team
        /// </summary>
        public Player[] Players
        {
            get
            {
                MTAElement[] mtaPlayers = MTAShared.GetArrayFromTable(MTAShared.GetPlayersInTeam(MTAElement), "MTAElement");
                return ElementManager.Instance.CastArray<Player>(mtaPlayers);
            }
        }

        #endregion


        [EditorBrowsable(EditorBrowsableState.Never)]
        public Team(MTAElement team) : base(team)
        {

        }
    }
}
