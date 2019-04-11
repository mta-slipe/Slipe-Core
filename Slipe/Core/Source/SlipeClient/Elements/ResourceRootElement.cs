using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Elements
{
    public class ResourceRootElement : Element
    {
        public ResourceRootElement(MtaElement element) : base(element)
        {
            this.ListenForEvent("onClientFileDownloadComplete");
        }

        public override void HandleEvent(string eventName, MtaElement element, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8)
        {
            switch (eventName)
            {
                case "onClientFileDownloadComplete":
                    OnFileDownloadComplete?.Invoke((string)p1, (bool)p2);
                    break;
            }
        }

        public delegate void OnFileDownloadCompleteHandler(string path, bool success);
        public static event OnFileDownloadCompleteHandler OnFileDownloadComplete;
    }
}
