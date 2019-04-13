using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using Slipe.Client.Sounds;
using Slipe.Client.Rendering;
using Slipe.Client.IO;
using Slipe.Shared.Helpers;

namespace Slipe.Client.GameClient
{
    /// <summary>
    /// Static class that handles calls to functions related to the client
    /// </summary>
    public static class Client
    {
        #region Properties

        /// <summary>
        /// Get the renderer object
        /// </summary>
        public static Renderer Renderer
        {
            get
            {
                return Renderer.Instance;
            }
        }

        /// <summary>
        /// Get the Engine object
        /// </summary>
        public static Engine Engine
        {
            get
            {
                return Engine.Instance;
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
        /// Get if voice is currently enabled
        /// </summary>
        public static bool IsVoiceEnabled
        {
            get
            {
                return MtaShared.IsVoiceEnabled();
            }
        }

        /// <summary>
        /// Get and set the radio channel that's playing on the client (even when not in a vehicle)
        /// </summary>
        public static RadioStation ActiveRadioStation
        {
            get
            {
                return (RadioStation)MtaClient.GetRadioChannel();
            }
            set
            {
                MtaClient.SetRadioChannel((int)value);
            }
        }

        /// <summary>
        /// Get and set if the input is focused on Gui elements
        /// </summary>
        public static bool GuiInputEnabled
        {
            get
            {
                return MtaClient.GuiGetInputEnabled();
            }
            set
            {
                MtaClient.GuiSetInputEnabled(value);
            }
        }

        /// <summary>
        /// Get and set the input mode
        /// </summary>
        public static InputMode InputMode
        {
            get
            {
                return (InputMode) Enum.Parse(typeof(InputMode), MtaClient.GuiGetInputMode(), true);
            }
            set
            {
                MtaClient.GuiSetInputMode(value.ToString().ToLower());
            }
        }

        /// <summary>
        /// Get whether the user is in the main menu or not
        /// </summary>
        public static bool IsMainMenuActive
        {
            get
            {
                return MtaClient.IsMainMenuActive();
            }
        }

        /// <summary>
        /// Get if any system windows that take focus are active.
        /// </summary>
        public static bool IsMtaWindowActive
        {
            get
            {
                return MtaClient.IsMTAWindowActive();
            }
        }

        /// <summary>
        /// Get if the download box is active
        /// </summary>
        public static bool IsTransferBoxActive
        {
            get
            {
                return MtaClient.IsTransferBoxActive();
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
        /// Get the current MTA version of this client
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
        /// Get a string tuple representing the localization of this client. The first string is the short code, the second the full language name
        /// </summary>
        public static Tuple<string, string> Localization
        {
            get
            {
                Dictionary<string, string> d = MtaShared.GetDictionaryFromTable(MtaClient.GetLocalization(), "System.String", "System.String");
                return new Tuple<string, string>(d["code"], d["name"]);
            }
        }

        /// <summary>
        /// Get if the client allows tray notifications from MTA
        /// </summary>
        public static bool IsTrayNotificationEnabled
        {
            get
            {
                return MtaClient.IsTrayNotificationEnabled();
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Create a windows tray notification
        /// </summary>
        public static void CreateTrayNotification(string text, TrayIconType trayIcon = 0, bool useSound = true)
        {
            MtaClient.CreateTrayNotification(text, trayIcon.ToString().ToLower(), useSound);
        }

        /// <summary>
        /// Set the client's clipboard text
        /// </summary>
        public static bool SetClipboard(string text)
        {
            return MtaClient.SetClipboard(text);
        }

        /// <summary>
        /// Set the client's window flashing
        /// </summary>
        public static bool SetWindowFlashing(bool shouldFlash, int count = 10)
        {
            return MtaClient.SetWindowFlashing(shouldFlash, count);
        }

        #endregion
    }
}
