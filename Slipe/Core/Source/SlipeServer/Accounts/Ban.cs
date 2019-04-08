using Slipe.Shared;
using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Slipe.Server.Peds;

namespace Slipe.Server.Accounts
{
    /// <summary>
    /// A ban is a pointer that represents a banned player arbitrarily.
    /// </summary>
    public class Ban
    {
        private readonly MTABan ban;

        #region Properties

        /// <summary>
        /// Get and set the nickname of the player that added this ban
        /// </summary>
        public string Admin
        {
            get
            {
                return MTAServer.GetBanAdmin(ban);
            }
            set
            {
                MTAServer.SetBanAdmin(ban, value);
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
                    return MTAServer.GetBanIP(ban);
                }
                catch (MTAException)
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
                    return MTAServer.GetBanSerial(ban);
                }
                catch (MTAException)
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
                return MTAServer.GetBanReason(ban);
            }
            set
            {
                MTAServer.SetBanReason(ban, value);
            }
        }

        /// <summary>
        /// Get or set the nickname of the banned player
        /// </summary>
        public string Nickname
        {
            get
            {
                return MTAServer.GetBanNick(ban);
            }
            set
            {
                MTAServer.SetBanNick(ban, value);
            }
        }

        /// <summary>
        /// Get the timestamp this ban was added
        /// </summary>
        public int TimeStamp
        {
            get
            {
                return MTAServer.GetBanTime(ban);
            }
        }

        /// <summary>
        /// Get or set the timesteamp this ban was lifted
        /// </summary>
        public int UnbanTimeStamp
        {
            get
            {
                return MTAServer.GetUnbanTime(ban);
            }
            set
            {
                MTAServer.SetUnbanTime(ban, value);
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
                dynamic[] mtaBans = MTAShared.GetArrayFromTable(MTAServer.GetBans(), "ban");
                Ban[] bans = new Ban[mtaBans.Length];
                for (int i = 0; i < mtaBans.Length; i++)
                {
                    bans[i] = new Ban((MTABan)mtaBans[i]);
                }
                return bans;
            }
        }

        #region Constructors

        /// <summary>
        /// Add a ban of a specific IP and/or serial
        /// </summary>
        public Ban(string ip, string serial, Player banner, string reason, int seconds)
        {
            ban = MTAServer.AddBan(ip, null, serial, banner == null ? null : banner.MTAElement, reason, seconds);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        private Ban(MTABan ban)
        {
            this.ban = ban;
        }

        #endregion

        /// <summary>
        /// Remove this ban
        /// </summary>
        public void Remove(Player player)
        {
            MTAServer.RemoveBan(ban, player == null ? null : player.MTAElement);
        }

        /// <summary>
        /// Remove this ban without any unbanning player
        /// </summary>
        public void Remove()
        {
            Remove(null);
        }


    }
}
