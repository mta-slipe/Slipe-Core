using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Server.Accounts;
using Slipe.Server.Peds;
using Slipe.Shared.IO;
using Slipe.Shared.Utilities;
using Slipe.Server.IO;
using Slipe.Server.GameServer;

namespace Slipe.Server.Elements
{
    public class RootElement: Element
    {
        public RootElement(MtaElement element) : base(element)
        {
            OnAccountDataChange += (Account account, string key, string value) => { account.HandleDataChange(key, value); };
            OnBanAdded += (Ban ban) => { ban.HandleAdded(); };
            OnBanRemoved += (Ban ban, Player responsiblePlayer) => { ban.HandleRemoved(responsiblePlayer); };
            OnPlayerConnect += (string nickName, string Ip, string username, string serial, int versionNumber, string versionString) => { Process.HandlePlayerConnected(nickName, Ip, username, serial, versionNumber, versionString); };
            OnChatMessage += (string message, Element playerOrResource) => { ChatBox.HandleMessage(message, playerOrResource); };
            OnDebugMessage += (string message, DebugMessageLevel level, string file, int line, Color color) => { Process.Debug.HandleMessage(message, level, file, line, color); };
            OnSettingChange += (string setting, string oldValue, string newValue) => { Process.HandleSettingChange(setting, oldValue, newValue); };
        }

        public override void HandleEvent(string eventName, MtaElement element, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8)
        {
            OnMiscelaniousEvent?.Invoke(eventName, element, p1, p2, p3, p4, p5, p6, p7, p8);
        }

        #pragma warning disable 67

        public delegate void OnMiscelaniousEventHandler(string eventName, MtaElement element, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8);
        public static event OnMiscelaniousEventHandler OnMiscelaniousEvent;

        internal delegate void OnAccountDataChangeHandler(Account account, string key, string value);
        internal static event OnAccountDataChangeHandler OnAccountDataChange;

        internal delegate void OnBanAddedHandler(Ban ban);
        internal static event OnBanAddedHandler OnBanAdded;

        internal delegate void OnBanRemovedHandler(Ban ban, Player responsiblePlayer);
        internal static event OnBanRemovedHandler OnBanRemoved;

        internal delegate void OnPlayerConnectHandler(string nickName, string Ip, string username, string serial, int versionNumber, string versionString);
        internal static event OnPlayerConnectHandler OnPlayerConnect;

        internal delegate void OnChatMessageHandler(string message, Element playerOrResource);
        internal static event OnChatMessageHandler OnChatMessage;

        internal delegate void OnDebugMessageHandler(string message, DebugMessageLevel level, string file, int line, Color color);
        internal static event OnDebugMessageHandler OnDebugMessage;

        internal delegate void OnSettingChangeHandler(string setting, string oldValue, string newValue);
        internal static event OnSettingChangeHandler OnSettingChange;

        #pragma warning restore 67
    }
}
