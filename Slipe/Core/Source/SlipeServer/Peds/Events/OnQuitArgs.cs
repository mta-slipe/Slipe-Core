using Slipe.Shared.Peds;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnQuitArgs
    {
        /// <summary>
        /// How the player left.
        /// </summary>
        public QuitType QuitType { get; }

        /// <summary>
        /// If the player was kicked or banned, the reason given goes here. 
        /// </summary>
        public string Reason { get; }

        /// <summary>
        /// The player that was responsible for kicking or banning the player.
        /// </summary>
        public Player ResponsiblePlayer { get; }

        internal OnQuitArgs(QuitType quitType, string reason, Player responsiblePlayer)
        {
            QuitType = quitType;
            Reason = reason;
            ResponsiblePlayer = responsiblePlayer;
        }
    }
}
