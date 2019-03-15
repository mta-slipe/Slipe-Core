using Slipe.Shared;
using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Slipe.Server
{
    public class Player : SharedPlayer
    {
        public Player(Slipe.MTADefinitions.MTAElement mtaElement) : base(mtaElement)
        {
            Camera = new Camera(this);
        }

        public Camera Camera { get; }

        public int WantedLevel
        {
            set
            {
                MTAServer.SetPlayerWantedLevel(element, value);
            }
        }

        public override string Name
        {
            get
            {
                return MTAShared.GetPlayerName(element);
            }
            set
            {
                MTAServer.SetPlayerName(element, value);
            }
        }

        public Team Team
        {
            get
            {
                MTAElement mtaTeam = MTAShared.GetPlayerTeam(element);
                return (Team)ElementManager.Instance.GetElement(mtaTeam);
            }
            set
            {
                MTAServer.SetPlayerTeam(MTAElement, value.MTAElement);
            }
        }

        public void Spawn(Vector3 position, int rotation = 0, int skin = 0, int interior = 0, int dimension = 0, Team team = null)
        {
            MTAServer.SpawnPlayer(element, position.X, position.Y, position.Z, rotation, skin, interior, dimension, team == null ? null : team.MTAElement);
        }
    }
}
