using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Elements
{
    public class RootElement: Element
    {
        public RootElement(MtaElement element) : base(element)
        {

        }


        public override void HandleEvent(string eventName, MtaElement element, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8)
        {
            switch (eventName)
            {
                default:
                    OnMiscelaniousEvent?.Invoke(eventName, element, p1, p2, p3, p4, p5, p6, p7, p8);
                    break;
            }
        }


        public delegate void OnMiscelaniousEventHandler(string eventName, MtaElement element, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8);
        public static event OnMiscelaniousEventHandler OnMiscelaniousEvent;
    }
}
