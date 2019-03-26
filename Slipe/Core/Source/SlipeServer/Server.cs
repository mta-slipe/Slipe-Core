using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Server.Enums;
using Slipe.MTADefinitions;

namespace Slipe.Server
{
    /// <summary>
    /// Class that handles methods on the global server
    /// </summary>
    class Server
    {
        private static Server instance;
        public static Server Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Server();
                }
                return instance;
            }
        }

        /// <summary>
        /// Get and set the server password
        /// </summary>
        public string Password
        {
            get
            {
                return MTAServer.GetServerPassword();
            }
            set
            {
                MTAServer.SetServerPassword(value);
            }
        }

        /// <summary>
        /// Get and set the player limit
        /// </summary>
        public int MaxPlayers
        {
            get
            {
                return MTAServer.GetMaxPlayers();
            }
            set
            {
                MTAServer.SetMaxPlayers(value);
            }
        }

        /// <summary>
        /// Get and set the FPS limit
        /// </summary>
        public int FPSLimit
        {
            get
            {
                return MTAShared.GetFPSLimit();
            }
            set
            {
                MTAShared.SetFPSLimit(value);
            }
        }

        /// <summary>
        /// Get the current MTA version of this server
        /// </summary>
        public string Version { get { return MTAShared.GetVersion(); } }

        /// <summary>
        /// Get the port this server runs on
        /// </summary>
        public int Port { get { return MTAServer.GetServerPort(); } }

        /// <summary>
        /// Get the HTTP port of this server
        /// </summary>
        public int HTTPPort { get { return MTAServer.GetServerHttpPort(); } }

        /// <summary>
        /// Get the name of this server
        /// </summary>
        public string Name { get { return MTAServer.GetServerName(); } }


        /// <summary>
        /// Enable or disable a certain known GTA glitch
        /// </summary>
        public bool SetGlitchEnabled(Glitch glitch, bool enabled)
        {
            return MTAServer.SetGlitchEnabled(glitch.ToString("f").ToLower(), enabled);
        }

        /// <summary>
        /// Check if a certain GTA glitch is enabled
        /// </summary>
        public bool IsGlitchEnabled(Glitch glitch)
        {
            return MTAServer.IsGlitchEnabled(glitch.ToString("f").ToLower());
        }

        /// <summary>
        /// Terminates the server process
        /// </summary>
        public void Shutdown(string reason)
        {
            MTAServer.Shutdown(reason);
        }
    }
}
