using Slipe.Shared;
using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server
{
    public class Ban
    {
        private readonly MTABan ban;

        public Ban(string ip, string serial, Player banner, string reason, int seconds)
        {
            ban = MTAServer.AddBan(ip, null, serial, banner == null ? null : banner.MTAElement, reason, seconds);
        }

        private Ban(MTABan ban)
        {
            this.ban = ban;
        }

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

        public string Ip
        {
            get
            {
                try
                {
                    return MTAServer.GetBanIP(ban);
                } catch (MTAException)
                {
                    return null;
                }
            }
        }

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

        public int TimeStamp
        {
            get
            {
                return MTAServer.GetBanTime(ban);
            }
        }

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

        public void Remove(Element element)
        {
            MTAServer.RemoveBan(ban, element == null ? null : element.MTAElement);
        }

        public static List<Ban> GetAll()
        {
            List<dynamic> bans = MTAShared.GetListFromTable(MTAServer.GetBans());
            List<Ban> result = new List<Ban>();
            foreach(dynamic ban in bans)
            {
                result.Add(new Ban(ban));
            }
            return result;
        }
    }
}
