using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Game
{
    public class Announcement
    {
        public string GameType
        {
            get => MtaServer.GetGameType();
            set => MtaServer.SetGameType(value);
        }

        public string MapName
        {
            get => MtaServer.GetMapName();
            set => MtaServer.SetGameType(value);
        }

        public bool SetRuleValue(string key, string value) => MtaServer.SetRuleValue(key, value);
        public string GetRuleValue(string key) => MtaServer.GetRuleValue(key);
        public bool RemoveRuleValue(string key) => MtaServer.RemoveRuleValue(key);
    }
}
