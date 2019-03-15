using Slipe.Shared;
using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server
{
    public class Team: Element
    {
        public int PlayerCount { get { return MTAShared.CountPlayersInTeam(MTAElement); } }

        public string Name {
            get
            {
                return MTAShared.GetTeamName(MTAElement);
            }
            set
            {
                MTAServer.SetTeamName(MTAElement, value);
            }
        }

        public bool FriendlyFire {
            get
            {
                return MTAShared.GetTeamFriendlyFire(MTAElement);
            }
            set
            {
                MTAServer.SetTeamFriendlyFire(MTAElement, value);
            }
        }

        public Color Color {
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

        public List<Player> Players
        {
            get
            {
                List<Player> players = new List<Player>();
                List<dynamic> mtaPlayers = MTAShared.GetListFromTable(MTAShared.GetPlayersInTeam(MTAElement));
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
