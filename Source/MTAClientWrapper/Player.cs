using MTASharedWrapper;
using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTAClientWrapper
{
    public class Player : SharedPlayer
    {
        public Team Team
        {
            get
            {
                MTAElement mtaTeam = Shared.GetPlayerTeam(element);
                return (Team) ElementManager.Instance.GetElement(mtaTeam);
            }
        }

        public Player(MultiTheftAuto.MTAElement mtaElement) : base(mtaElement)
        {
        }
    }
}
