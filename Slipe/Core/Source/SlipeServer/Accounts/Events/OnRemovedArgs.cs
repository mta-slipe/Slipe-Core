using Slipe.Server.Peds;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Accounts.Events
{
    public class OnRemovedArgs
    {
        public Player ResponsiblePlayer;

        internal OnRemovedArgs(Player player)
        {
            ResponsiblePlayer = player;
        }
    }
}
