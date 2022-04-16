using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;
using SlipeLua.Server.Elements;
using SlipeLua.Server.Game;
using SlipeLua.Server.Game.Events;
using SlipeLua.Server.IO;
using SlipeLua.Server.Resources;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Helpers;

namespace SlipeLua.Server.Game
{
    /// <summary>
    /// Static class for functionality of the actual server process
    /// </summary>
    public static class GameServer
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

        private static Config config;
        /// <summary>
        /// Get the server config handler
        /// </summary>
        public static Config Config
        {
            get
            {
                if (config == null)
                    config = new Config();
                return config;
            }
        }

        /// <summary>
        /// Get the amount of time that the system has been running in milliseconds.
        /// </summary>
        public static int TickCount
        {
            get
            {
                return MtaShared.GetTickCount();
            }
        }

        private static SystemVersion version;
        /// <summary>
        /// Get the current MTA version of this server
        /// </summary>
        public static SystemVersion Version
        {
            get
            {
                if (version == null)
                    version = new SystemVersion();
                return version;
            }
        }

        /// <summary>
        /// Returns the MTA F8 console
        /// </summary>
        private static MtaConsole console;
        public static MtaConsole Console
        {
            get
            {
                if (console == null)
                {
                    console = new MtaConsole();
                }
                return console;
            }
        }

        /// <summary>
        /// Returns the MTA debug view
        /// </summary>
        private static MtaDebug debug;
        public static MtaDebug Debug
        {
            get
            {
                if (debug == null)
                {
                    debug = new MtaDebug();
                }
                return debug;
            }
        }

        /// <summary>
        /// Returns the MTA Server Log
        /// </summary>
        private static ServerLog log;
        public static ServerLog Log
        {
            get
            {
                if (log == null)
                {
                    log = new ServerLog();
                }
                return log;
            }
        }

        private static Announcement announcement;
        /// <summary>
        /// Returns the MTA Server Log
        /// </summary>
        public static Announcement Announcement
        {
            get
            {
                if (announcement == null)
                {
                    announcement = new Announcement();
                }
                return announcement;
            }
        }



        /// <summary>
        /// Get and set the limit at which clients can run their game on this server
        /// </summary>
        public static int FpsLimit
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

        #endregion

        #region Methods

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

        #endregion

        #region Events
#pragma warning disable 67

        public delegate void OnPreStartHandler(ResourceRootElement source, OnPreStartEventArgs eventARgs);
        public static event OnPreStartHandler OnPreStart;

        public delegate void OnStartHandler(ResourceRootElement source, OnStartEventArgs eventArgs);
        public static event OnStartHandler OnStart;

        public delegate void OnStopHandler(ResourceRootElement source, OnStopEventArgs eventArgs);
        public static event OnStopHandler OnStop;

        public delegate void OnPlayerConnectHandler(RootElement source, OnPlayerConnectEventArgs eventArgs);
        public static event OnPlayerConnectHandler OnPlayerConnect;

        public delegate void OnSettingChangeHandler(RootElement source, OnSettingChangeEventArgs eventArgs);
        public static event OnSettingChangeHandler OnSettingChange;
#pragma warning enable 67
        #endregion
    }
}
