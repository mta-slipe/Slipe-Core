using MTASharedWrapper;
using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTAClientWrapper
{
    public class Team: Element
    {
        public string Name { get { return Shared.GetTeamName(MTAElement); } }
        public bool FriendlyFire { get { return Shared.GetTeamFriendlyFire(MTAElement); } }
        public int PlayerCount { get { return Shared.CountPlayersInTeam(MTAElement); } }

        public Color Color {
            get
            {
                Tuple<int, int, int> color = Shared.GetTeamColor(MTAElement);
                return new Color((byte)color.Item1, (byte)color.Item2, (byte)color.Item3);
            }
        }

        public List<Player> Players
        {
            get
            {
                List<Player> players = new List<Player>();
                List<dynamic> mtaPlayers = Shared.GetListFromTable(Shared.GetPlayersInTeam(MTAElement));
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
