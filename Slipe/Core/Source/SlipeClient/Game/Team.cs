﻿using SlipeLua.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Utilities;
using System.ComponentModel;
using SlipeLua.Client.Peds;

namespace SlipeLua.Client.Game
{
    /// <summary>
    /// Class representing a team of players
    /// </summary>
    [DefaultElementClass(ElementType.Team)]
    public class Team : Element
    {
        #region Properties
        /// <summary>
        /// Get the name of the team
        /// </summary>
        public string Name { get { return MtaShared.GetTeamName(MTAElement); } }

        /// <summary>
        /// Get if friendly fire is enabled
        /// </summary>
        public bool FriendlyFire { get { return MtaShared.GetTeamFriendlyFire(MTAElement); } }

        /// <summary>
        /// Get the amount of players in this team
        /// </summary>
        public int PlayerCount { get { return MtaShared.CountPlayersInTeam(MTAElement); } }

        /// <summary>
        /// Get the color of this team
        /// </summary>
        public Color Color
        {
            get
            {
                Tuple<int, int, int> color = MtaShared.GetTeamColor(MTAElement);
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
                MtaElement[] mtaPlayers = MtaShared.GetArrayFromTable(MtaShared.GetPlayersInTeam(MTAElement), "element");
                return ElementManager.Instance.CastArray<Player>(mtaPlayers);
            }
        }
        #endregion

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Team(MtaElement team) : base(team)
        {

        }
    }
}
