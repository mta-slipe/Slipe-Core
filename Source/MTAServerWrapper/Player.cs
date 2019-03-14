using MTASharedWrapper;
using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace MTAServerWrapper
{
    public class Player : SharedPlayer
    {
        public Player(MultiTheftAuto.MTAElement mtaElement) : base(mtaElement)
        {
            Camera = new Camera(this);
        }

        public Camera Camera { get; }

        public int WantedLevel
        {
            set
            {
                Server.SetPlayerWantedLevel(element, value);
            }
        }

        public override string Name
        {
            get
            {
                return Shared.GetPlayerName(element);
            }
            set
            {
                Server.SetPlayerName(element, value);
            }
        }

        public Team Team
        {
            get
            {
                MTAElement mtaTeam = Shared.GetPlayerTeam(element);
                return (Team)ElementManager.Instance.GetElement(mtaTeam);
            }
            set
            {
                Server.SetPlayerTeam(MTAElement, value.MTAElement);
            }
        }

        public void Spawn(Vector3 position, int rotation = 0, int skin = 0, int interior = 0, int dimension = 0, Team team = null)
        {
            Server.SpawnPlayer(element, position.X, position.Y, position.Z, rotation, skin, interior, dimension, team == null ? null : team.MTAElement);
        }
    }
}
