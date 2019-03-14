using MTASharedWrapper;
using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTAServerWrapper
{
    public class Team: Element
    {
        public int PlayerCount { get { return Shared.CountPlayersInTeam(MTAElement); } }

        public string Name {
            get
            {
                return Shared.GetTeamName(MTAElement);
            }
            set
            {
                Server.SetTeamName(MTAElement, value);
            }
        }

        public bool FriendlyFire {
            get
            {
                return Shared.GetTeamFriendlyFire(MTAElement);
            }
            set
            {
                Server.SetTeamFriendlyFire(MTAElement, value);
            }
        }

        public Color Color {
            get
            {
                Tuple<int, int, int> color = Shared.GetTeamColor(MTAElement);
                return new Color((byte)color.Item1, (byte)color.Item2, (byte)color.Item3);
            }
            set
            {
                Server.SetTeamColor(MTAElement, value.R, value.G, value.B);
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
                    players.Add((Player) ElementManager.Instance.GetElement((MTAElement)player));
                }
                return players;
            }
        }



        internal Team(MTAElement team) : base(team)
        {

        }
    }
}
