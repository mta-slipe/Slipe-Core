using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Slipe.Server.Peds;
using Slipe.Server.Accounts.Events;
using Slipe.Shared.Elements;
using Slipe.Server.Elements;

namespace Slipe.Server.Accounts
{
    /// <summary>
    /// A ban is a pointer that represents a banned player arbitrarily.
    /// </summary>
    public sealed class Ban
    {
        private readonly MtaBan ban;

        #region Properties

        /// <summary>
        /// Get and set the nickname of the player that added this ban
        /// </summary>
        public string Admin
        {
            get
            {
                return MtaServer.GetBanAdmin(ban);
            }
            set
            {
                MtaServer.SetBanAdmin(ban, value);
            }
        }

        /// <summary>
        /// Get the IP of this ban. Can return null if no IP is linked
        /// </summary>
        public string Ip
        {
            get
            {
                try
                {
                    return MtaServer.GetBanIP(ban);
                }
                catch (MtaException)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Get the serial of this ban. Can return null if no serial is linked
        /// </summary>
        public string Serial
        {
            get
            {
                try
                {
                    return MtaServer.GetBanSerial(ban);
                }
                catch (MtaException)
                {
                    return null;
                }

            }
        }

        /// <summary>
        /// Get or set the ban reason
        /// </summary>
        public string Reason
        {
            get
            {
                return MtaServer.GetBanReason(ban);
            }
            set
            {
                MtaServer.SetBanReason(ban, value);
            }
        }

        /// <summary>
        /// Get or set the nickname of the banned player
        /// </summary>
        public string Nickname
        {
            get
            {
                return MtaServer.GetBanNick(ban);
            }
            set
            {
                MtaServer.SetBanNick(ban, value);
            }
        }

        /// <summary>
        /// Get the timestamp this ban was added
        /// </summary>
        public int TimeStamp
        {
            get
            {
                return MtaServer.GetBanTime(ban);
            }
        }

        /// <summary>
        /// Get or set the timesteamp this ban was lifted
        /// </summary>
        public int UnbanTimeStamp
        {
            get
            {
                return MtaServer.GetUnbanTime(ban);
            }
            set
            {
                MtaServer.SetUnbanTime(ban, value);
            }
        }

        #endregion

        /// <summary>
        /// Get a list of all bans in this server
        /// </summary>
        public static Ban[] All
        {
            get
            {
                dynamic[] mtaBans = MtaShared.GetArrayFromTable(MtaServer.GetBans(), "ban");
                Ban[] bans = new Ban[mtaBans.Length];
                for (int i = 0; i < mtaBans.Length; i++)
                {
                    bans[i] = new Ban((MtaBan)mtaBans[i]);
                }
                return bans;
            }
        }

        #region Constructors

        /// <summary>
        /// Add a ban of a specific IP and/or serial
        /// </summary>
        public Ban(string ip, string serial, Player banner, string reason, int seconds)
            : this(MtaServer.AddBan(ip, null, serial, banner == null ? null : banner.MTAElement, reason, seconds)) { }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Ban(MtaBan ban)
        {
            this.ban = ban;
        }

        #endregion

        /// <summary>
        /// Remove this ban
        /// </summary>
        public void Remove(Player player)
        {
            MtaServer.RemoveBan(ban, player == null ? null : player.MTAElement);
        }

        /// <summary>
        /// Remove this ban without any unbanning player
        /// </summary>
        public void Remove()
        {
            Remove(null);
        }

        #region Events

#pragma warning disable 67

        public delegate void OnRemoveHandler(RootElement source, OnRemovedEventArgs eventArgs);
        public static event OnRemoveHandler OnRemoved;

        public delegate void OnAddedHandler(RootElement source, OnAddedEventArgs eventArgs);
        public static event OnAddedHandler OnAdded;

#pragma warning enable 67

        #endregion


    }
}
