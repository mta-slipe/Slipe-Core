using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Peds.Events
{
    public class OnNicknameChangedEventArgs
    {
        /// <summary>
        /// The nickname the player had before.
        /// </summary>
        public string OldNickname { get; }

        /// <summary>
        /// The new nickname of the player.
        /// </summary>
        public string NewNickname { get; }

        /// <summary>
        /// Whether the name was changed using setPlayerName or by the user.
        /// </summary>
        public bool IsChangedByUser { get; }

        internal OnNicknameChangedEventArgs(dynamic oldNickname, dynamic newNickname, dynamic changedByuser)
        {
            OldNickname = (string) oldNickname;
            NewNickname = (string) newNickname;
            IsChangedByUser = (bool) changedByuser;
        }
    }
}
