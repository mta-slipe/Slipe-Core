using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;

namespace Slipe.Server.GameServer
{
    /// <summary>
    /// Class that handles methods on the global server
    /// </summary>
    public static class Server
    {
        #region Properties

        /// <summary>
        /// Get and set the server password
        /// </summary>
        public static string Password
        {
            get
            {
                return MtaServer.GetServerPassword();
            }
            set
            {
                MtaServer.SetServerPassword(value);
            }
        }

        /// <summary>
        /// Get and set the player limit
        /// </summary>
        public static int MaxPlayers
        {
            get
            {
                return MtaServer.GetMaxPlayers();
            }
            set
            {
                MtaServer.SetMaxPlayers(value);
            }
        }

        /// <summary>
        /// Get and set the FPS limit
        /// </summary>
        public static int FPSLimit
        {
            get
            {
                return MtaShared.GetFPSLimit();
            }
            set
            {
                MtaShared.SetFPSLimit(value);
            }
        }

        /// <summary>
        /// Get the current MTA version of this server
        /// </summary>
        public static string Version { get { return MtaShared.GetVersion(); } }

        /// <summary>
        /// Get the port this server runs on
        /// </summary>
        public static int Port { get { return MtaServer.GetServerPort(); } }

        /// <summary>
        /// Get the HTTP port of this server
        /// </summary>
        public static int HTTPPort { get { return MtaServer.GetServerHttpPort(); } }

        /// <summary>
        /// Get the name of this server
        /// </summary>
        public static string Name { get { return MtaServer.GetServerName(); } }

        /// <summary>
        /// Get if voice is currently enabled
        /// </summary>
        public static bool IsVoiceEnabled
        {
            get
            {
                return MtaShared.IsVoiceEnabled();
            }
        }

        #endregion

        /// <summary>
        /// Enable or disable a certain known GTA glitch
        /// </summary>
        public static bool SetGlitchEnabled(Glitch glitch, bool enabled)
        {
            return MtaServer.SetGlitchEnabled(glitch.ToString().ToLower(), enabled);
        }

        /// <summary>
        /// Check if a certain GTA glitch is enabled
        /// </summary>
        public static bool IsGlitchEnabled(Glitch glitch)
        {
            return MtaServer.IsGlitchEnabled(glitch.ToString().ToLower());
        }

        /// <summary>
        /// Terminates the server process
        /// </summary>
        public static void Shutdown(string reason)
        {
            MtaServer.Shutdown(reason);
        }
    }
}
