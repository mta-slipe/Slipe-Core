using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Game.Events
{
    public class OnPlayerConnectArgs
    {
        /// <summary>
        /// The nickname the player is connecting with
        /// </summary>
        public string Nickname { get; }

        /// <summary>
        /// The ip of the player
        /// </summary>
        public string Ip { get; }

        /// <summary>
        /// The username of the player
        /// </summary>
        public string Username { get; }

        /// <summary>
        /// The serial of the player
        /// </summary>
        public string Serial { get; }

        /// <summary>
        /// The version number of the player
        /// </summary>
        public int VersionNumber { get; }

        /// <summary>
        /// The string representation of the version
        /// </summary>
        public string VersionString { get; }

        internal OnPlayerConnectArgs(string nickname, string ip, string username, string serial, int versionNumber, string versionString)
        {
            Nickname = nickname;
            Ip = ip;
            Username = username;
            Serial = serial;
            VersionNumber = versionNumber;
            VersionString = versionString;
        }
    }
}
