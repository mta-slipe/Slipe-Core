using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Game.Events
{
    public class OnPlayerConnectEventArgs
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

        internal OnPlayerConnectEventArgs(dynamic nickname, dynamic ip, dynamic username, dynamic serial, dynamic versionNumber, dynamic versionString)
        {
            Nickname = (string) nickname;
            Ip = (string) ip;
            Username = (string) username;
            Serial = (string) serial;
            VersionNumber = (int) versionNumber;
            VersionString = (string) versionString;
        }
    }
}
