using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Client.Resources;
using Slipe.Client.Game;

namespace Slipe.Client.Elements
{
    [DefaultElementClass(ElementType.Resource)]
    public class ResourceRootElement : Element
    {
        public ResourceRootElement(MtaElement element) : base(element)
        {
            OnStart += (Resource resource) => {
                GameClient.HandleStart(resource);
                resource.HandleStart();
            };
            OnStop += (Resource resource) => {
                GameClient.HandleStop(resource);
                resource.HandleStop();
            };
        }

        #pragma warning disable 67

        public delegate void OnFileDownloadCompleteHandler(string path, bool success);
        public static event OnFileDownloadCompleteHandler OnFileDownloadComplete;

        internal delegate void OnStartHandler(Resource resource);
        internal event OnStartHandler OnStart;

        internal delegate void OnStopHandler(Resource resource);
        internal event OnStopHandler OnStop;

        #pragma warning restore 67

    }
}
