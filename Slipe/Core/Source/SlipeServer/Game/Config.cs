using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using Slipe.Server.Game;

namespace Slipe.Server.Game
{
    /// <summary>
    /// Represents server config fields
    /// </summary>
    public class Config
    {
        /// <summary>
        /// If set to true, changes to the server config are permanent as opposed to lasting till next server restart
        /// </summary>
        public bool PermanentSaveFlag { get; set; }

        /// <summary>
        /// The minimal client version for connecting players
        /// </summary>
        public string MinClientVersion
        {
            get
            {
                return MtaServer.GetServerConfigSetting("minclientversion");
            }
            set
            {
                MtaServer.SetServerConfigSetting("minclientversion", value, PermanentSaveFlag);
            }
        }

        /// <summary>
        /// The recommended client version for connecting players
        /// </summary>
        public string RecommendedClientVersion
        {
            get
            {
                return MtaServer.GetServerConfigSetting("recommendedclientversion");
            }
            set
            {
                MtaServer.SetServerConfigSetting("recommendedclientversion", value, PermanentSaveFlag);
            }
        }

        /// <summary>
        /// The password of this server
        /// </summary>
        public string Password
        {
            get
            {
                return MtaServer.GetServerConfigSetting("password");
            }
            set
            {
                MtaServer.SetServerConfigSetting("password", value, PermanentSaveFlag);
            }
        }

        /// <summary>
        /// The FPS limit of this server
        /// </summary>
        public int FpsLimit
        {
            get
            {
                return int.Parse(MtaServer.GetServerConfigSetting("fpslimit"));
            }
            set
            {
                MtaServer.SetServerConfigSetting("fpslimit", value.ToString(), PermanentSaveFlag);
            }
        }

        /// <summary>
        /// Whether to use network encryption or not
        /// </summary>
        public bool NetworkEncryption
        {
            get
            {
                return MtaServer.GetServerConfigSetting("networkencryption") == "1";
            }
            set
            {
                if (value)
                    MtaServer.SetServerConfigSetting("networkencryption", "1", PermanentSaveFlag);
                else
                    MtaServer.SetServerConfigSetting("networkencryption", "0", PermanentSaveFlag);

            }
        }

        /// <summary>
        /// The bandwidth reduction setting
        /// </summary>
        public BandwidthReduction BandwidthReduction
        {
            get
            {
                return (BandwidthReduction)Enum.Parse(typeof(BandwidthReduction), MtaServer.GetServerConfigSetting("bandwidth_reduction"), true);
            }
            set
            {
                MtaServer.SetServerConfigSetting("bandwidth_reduction", value.ToString().ToLower(), PermanentSaveFlag);
            }
        }

        /// <summary>
        /// Time between key sync correction updates for players. (Note: Player key sync is always done on demand and is not affected by any setting)
        /// </summary>
        public int PlayerSyncInterval
        {
            get
            {
                return int.Parse(MtaServer.GetServerConfigSetting("player_sync_interval"));
            }
            set
            {
                MtaServer.SetServerConfigSetting("player_sync_interval", value.ToString(), PermanentSaveFlag);
            }
        }

        /// <summary>
        /// Time between updates for very far away players
        /// </summary>
        public int LightweightSyncInterval
        {
            get
            {
                return int.Parse(MtaServer.GetServerConfigSetting("lightweight_sync_interval"));
            }
            set
            {
                MtaServer.SetServerConfigSetting("lightweight_sync_interval", value.ToString(), PermanentSaveFlag);
            }
        }

        /// <summary>
        /// How often to tell the server of any client side changes to the local players camera position and target.
        /// </summary>
        public int CameraSyncInterval
        {
            get
            {
                return int.Parse(MtaServer.GetServerConfigSetting("camera_sync_interval"));
            }
            set
            {
                MtaServer.SetServerConfigSetting("camera_sync_interval", value.ToString(), PermanentSaveFlag);
            }
        }

        /// <summary>
        /// Time between updates for non-player peds
        /// </summary>
        public int PedSyncInterval
        {
            get
            {
                return int.Parse(MtaServer.GetServerConfigSetting("ped_sync_interval"));
            }
            set
            {
                MtaServer.SetServerConfigSetting("ped_sync_interval", value.ToString(), PermanentSaveFlag);
            }
        }

        /// <summary>
        /// Time between updates for unoccupied vehicles
        /// </summary>
        public int UnoccupiedVehicleSyncInterval
        {
            get
            {
                return int.Parse(MtaServer.GetServerConfigSetting("unoccupied_vehicle_sync_interval"));
            }
            set
            {
                MtaServer.SetServerConfigSetting("unoccupied_vehicle_sync_interval", value.ToString(), PermanentSaveFlag);
            }
        }

        /// <summary>
        /// Minimum gap between mouse movement updates being sent to the server
        /// </summary>
        public int MouseKeySyncInterval
        {
            get
            {
                return int.Parse(MtaServer.GetServerConfigSetting("keysync_mouse_sync_interval"));
            }
            set
            {
                MtaServer.SetServerConfigSetting("keysync_mouse_sync_interval", value.ToString(), PermanentSaveFlag);
            }
        }

        /// <summary>
        /// Minimum gap between joystick partial axes movement updates being sent to the server. (Full axes movement is treated as key sync and is not limited by this setting)
        /// </summary>
        public int AnalogKeySyncInterval
        {
            get
            {
                return int.Parse(MtaServer.GetServerConfigSetting("keysync_analog_sync_interval"));
            }
            set
            {
                MtaServer.SetServerConfigSetting("keysync_analog_sync_interval", value.ToString(), PermanentSaveFlag);
            }
        }


        /// <summary>
        /// Create a new config handler
        /// </summary>
        public Config()
        {
            PermanentSaveFlag = false;
        }
    }
}
