using Slipe.MtaDefinitions;
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
        public int PlayerCount { get { return MtaShared.CountPlayersInTeam(MTAElement); } }

        /// <summary>
        /// Get and set the name of this team
        /// </summary>
        public string Name
        {
            get
            {
                return MtaShared.GetTeamName(MTAElement);
            }
            set
            {
                MtaServer.SetTeamName(MTAElement, value);
            }
        }

        /// <summary>
        /// Get and set the friendly fire property of this team
        /// </summary>
        public bool FriendlyFire
        {
            get
            {
                return MtaShared.GetTeamFriendlyFire(MTAElement);
            }
            set
            {
                MtaServer.SetTeamFriendlyFire(MTAElement, value);
            }
        }

        /// <summary>
        /// Get and set the team color
        /// </summary>
        public Color Color
        {
            get
            {
                Tuple<int, int, int> color = MtaShared.GetTeamColor(MTAElement);
                return new Color((byte)color.Item1, (byte)color.Item2, (byte)color.Item3);
            }
            set
            {
                MtaServer.SetTeamColor(MTAElement, value.R, value.G, value.B);
            }
        }

        /// <summary>
        /// Get a list of players on this team
        /// </summary>
        public Player[] Players
        {
            get
            {
                MtaElement[] mtaPlayers = MtaShared.GetArrayFromTable(MtaShared.GetPlayersInTeam(MTAElement), "MTAElement");
                return ElementManager.Instance.CastArray<Player>(mtaPlayers);
            }
        }

        #endregion


        [EditorBrowsable(EditorBrowsableState.Never)]
        public Team(MtaElement team) : base(team)
        {

        }

        /// <summary>
        /// Create a new team on the server
        /// </summary>
        /// <param name="name">The name of this team</param>
        /// <param name="color">The color of this team</param>
        public Team(string name, Color color) : this(MtaServer.CreateTeam(name, color.R, color.G, color.B)) { }
    }
}
