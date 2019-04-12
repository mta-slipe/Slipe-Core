using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Server.Accounts;
using Slipe.Server.Peds;
using Slipe.Server.Resources;
using Slipe.Shared.Resources;
using Slipe.Shared.IO;
using Slipe.Shared.Utilities;

namespace Slipe.Server.Elements
{
    public class RootElement: Element
    {
        public RootElement(MtaElement element) : base(element)
        {

        }

        public override void HandleEvent(string eventName, MtaElement element, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8)
        {
            OnMiscelaniousEvent?.Invoke(eventName, element, p1, p2, p3, p4, p5, p6, p7, p8);
        }

        #pragma warning disable 67

        public delegate void OnMiscelaniousEventHandler(string eventName, MtaElement element, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8);
        public static event OnMiscelaniousEventHandler OnMiscelaniousEvent;

        public delegate void OnAccountDataChangeHandler(Account account, string key, string value);
        public static event OnAccountDataChangeHandler OnAccountDataChange;

        public delegate void OnBanAddedHandler(Ban ban);
        public static event OnBanAddedHandler OnBanAdded;

        public delegate void OnBanRemovedHandler(Ban ban, Player responsiblePlayer);
        public static event OnBanRemovedHandler OnBanRemoved;

        public delegate void OnPlayerConnectHandler(string nickName, string Ip, string username, string serial, int versionNumber, string versionString);
        public static event OnPlayerConnectHandler OnPlayerConnect;

        public delegate void OnResourcePreStartHandler(Resource resource);
        public static event OnResourcePreStartHandler OnResourcePreStart;

        public delegate void OnResourceStartHandler(Resource resource);
        public static event OnResourceStartHandler OnResourceStart;

        public delegate void OnResourceStopHandler(Resource resource, bool wasDeleted);
        public static event OnResourceStopHandler OnResourceStop;

        public delegate void OnChatMessageHandler(string message, Element playerOrResource);
        public static event OnChatMessageHandler OnChatMessage;

        public delegate void OnDebugMessageHandler(string message, DebugMessageLevel level, string file, int line, Color color);
        public static event OnDebugMessageHandler OnDebugMessage;

        public delegate void OnSettingChangeHandler(string setting, string oldValue, string newValue);
        public static event OnSettingChangeHandler OnSettingChange;

        #pragma warning restore 67
    }
}
