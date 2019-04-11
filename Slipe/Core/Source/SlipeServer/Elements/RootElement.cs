using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Server.Accounts;

namespace Slipe.Server.Elements
{
    public class RootElement: Element
    {
        public RootElement(MtaElement element) : base(element)
        {
            ListenForEvent("onAccountDataChange");
        }


        public override void HandleEvent(string eventName, MtaElement element, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8)
        {
            switch (eventName)
            {
                case "onAccountDataChange":
                    Account acc = AccountManager.Instance.GetAccount((MtaAccount) p1);
                    acc.HandleEvent(eventName, p1, p2, p3, p4, p5, p6, p7, p8);
                    break;
                default:
                    OnMiscelaniousEvent?.Invoke(eventName, element, p1, p2, p3, p4, p5, p6, p7, p8);
                    break;
            }
        }


        public delegate void OnMiscelaniousEventHandler(string eventName, MtaElement element, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8);
        public static event OnMiscelaniousEventHandler OnMiscelaniousEvent;
    }
}
