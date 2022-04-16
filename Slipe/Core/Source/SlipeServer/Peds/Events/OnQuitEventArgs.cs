using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Peds;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Peds.Events
{
    public class OnQuitEventArgs
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

        internal OnQuitEventArgs(dynamic quitType, dynamic reason, dynamic responsiblePlayer)
        {
            QuitType = (QuitType)Enum.Parse(typeof(QuitType), (string)quitType);

            if (reason == false)
                Reason = "";
            else
                Reason = (string) reason;

            if (responsiblePlayer is bool)
                ResponsiblePlayer = null;
            else
                ResponsiblePlayer = ElementManager.Instance.GetElement<Player>(responsiblePlayer);
        }
    }
}
