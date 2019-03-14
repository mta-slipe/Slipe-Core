using MTASharedWrapper;
using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTAServerWrapper
{
    public class Ban
    {
        private readonly MTABan ban;

        public Ban(string ip, string serial, Player banner, string reason, int seconds)
        {
            ban = Server.AddBan(ip, null, serial, banner == null ? null : banner.MTAElement, reason, seconds);
        }

        private Ban(MTABan ban)
        {
            this.ban = ban;
        }

        public string Admin
        {
            get
            {
                return Server.GetBanAdmin(ban);
            }
            set
            {
                Server.SetBanAdmin(ban, value);
            }
        }

        public string Ip
        {
            get
            {
                return Server.GetBanIP(ban);
            }
        }

        public string Serial
        {
            get
            {
                return Server.GetBanSerial(ban);
            }
        }

        public string Reason
        {
            get
            {
                return Server.GetBanReason(ban);
            }
            set
            {
                Server.SetBanReason(ban, value);
            }
        }

        public string Nickname
        {
            get
            {
                return Server.GetBanNick(ban);
            }
            set
            {
                Server.SetBanNick(ban, value);
            }
        }

        public int TimeStamp
        {
            get
            {
                return Server.GetBanTime(ban);
            }
        }

        public int UnbanTimeStamp
        {
            get
            {
                return Server.GetUnbanTime(ban);
            }
            set
            {
                Server.SetUnbanTime(ban, value);
            }
        }

        public void Remove(Element element)
        {
            Server.RemoveBan(ban, element == null ? null : element.MTAElement);
        }

        public static List<Ban> GetAll()
        {
            List<dynamic> bans = Shared.GetListFromTable(Server.GetBans());
            List<Ban> result = new List<Ban>();
            foreach(dynamic ban in bans)
            {
                result.Add(new Ban(ban));
            }
            return result;
        }
    }
}
