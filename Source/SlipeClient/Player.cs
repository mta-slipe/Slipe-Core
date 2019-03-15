using Slipe.Shared;
using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client
{
    public class Player : SharedPlayer
    {
        public Team Team
        {
            get
            {
                MTAElement mtaTeam = MTAShared.GetPlayerTeam(element);
                return (Team) ElementManager.Instance.GetElement(mtaTeam);
            }
        }

        public static Player Local
        {
            get
            {
                return new Player(MTAClient.GetLocalPlayer());
            }
        }

        public Player(Slipe.MTADefinitions.MTAElement mtaElement) : base(mtaElement)
        {
        }
    }
}
