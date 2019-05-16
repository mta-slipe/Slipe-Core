using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Peds.Events
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

        internal OnNicknameChangedEventArgs(dynamic oldNickname, dynamic newNickname)
        {
            OldNickname = (string) oldNickname;
            NewNickname = (string) newNickname;
        }
    }
}
