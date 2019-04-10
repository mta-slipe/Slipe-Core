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

        public override void HandleEvent(string eventName, MtaElement element, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8)
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
