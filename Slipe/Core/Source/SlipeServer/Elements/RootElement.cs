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
using Slipe.Server.Game;

namespace Slipe.Server.Elements
{
    [DefaultElementClass(ElementType.Root)]
    public class RootElement: Element
    {
        public RootElement(MtaElement element) : base(element) { }

        public override void HandleEvent(string eventName, MtaElement element, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8)
        {
            OnMiscelaniousEvent?.Invoke(eventName, element, p1, p2, p3, p4, p5, p6, p7, p8);
        }

        #pragma warning disable 67

        public delegate void OnMiscelaniousEventHandler(string eventName, MtaElement element, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8);
        public static event OnMiscelaniousEventHandler OnMiscelaniousEvent;

        #pragma warning restore 67
    }
}
