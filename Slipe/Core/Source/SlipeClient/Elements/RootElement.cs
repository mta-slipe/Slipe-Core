using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Elements
{
    public class RootElement: Element
    {
        public RootElement(MtaElement element) : base(element)
        {
            this.ListenForEvent("onClientKey");

            this.ListenForEvent("onClientRender");
            this.ListenForEvent("onClientPreRender");
            this.ListenForEvent("onClientHUDRender");
        }

        public override void HandleEvent(string eventName, MtaElement element, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8)
        {
            switch (eventName)
            {
                case "onClientKey":
                    OnKey?.Invoke((string)p1, (bool) p2);
                    break;
                case "onClientRender":
                    OnRender?.Invoke();
                    break;
                case "onClientPreRender":
                    OnPreRender?.Invoke((float) p1);
                    break;
                case "onClientHUDRender":
                    OnHUDRender?.Invoke();
                    break;
                default:
                    OnMiscelaniousEvent?.Invoke(eventName, element, p1, p2, p3, p4, p5, p6, p7, p8);
                    break;
            }
        }

        public delegate void OnKeyHandler(string key, bool isPressed);
        public static event OnKeyHandler OnKey;

        public delegate void OnRenderHandler();
        public static event OnRenderHandler OnRender;

        public delegate void OnPreRenderHandler(float timeSlice);
        public static event OnPreRenderHandler OnPreRender;

        public delegate void OnHUDRenderHandler();
        public static event OnRenderHandler OnHUDRender;

        public delegate void OnMiscelaniousEventHandler(string eventName, MtaElement element, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8);
        public static event OnMiscelaniousEventHandler OnMiscelaniousEvent;
    }
}
