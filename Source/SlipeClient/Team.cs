using Slipe.Shared;
using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client
{
    public class Team: Element
    {
        public string Name { get { return MTAShared.GetTeamName(MTAElement); } }
        public bool FriendlyFire { get { return MTAShared.GetTeamFriendlyFire(MTAElement); } }
        public int PlayerCount { get { return MTAShared.CountPlayersInTeam(MTAElement); } }

        public Color Color {
            get
            {
                Tuple<int, int, int> color = MTAShared.GetTeamColor(MTAElement);
                return new Color((byte)color.Item1, (byte)color.Item2, (byte)color.Item3);
            }
        }

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



        internal Team(MTAElement team) : base(team)
        {

        }
    }
}
