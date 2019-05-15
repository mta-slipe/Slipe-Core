using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnNicknameChangedArgs
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

        internal OnNicknameChangedArgs(string oldNickname, string newNickname, bool changedByuser)
        {
            OldNickname = oldNickname;
            NewNickname = newNickname;
            IsChangedByUser = changedByuser;
        }
    }
}
