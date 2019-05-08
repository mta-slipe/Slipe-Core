using Slipe.MtaDefinitions;
using Slipe.Server.Game;
using Slipe.Server.Resources;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Elements
{
    [DefaultElementClass(ElementType.Resource)]
    public class ResourceRootElement: Element
    {
        public ResourceRootElement(MtaElement element) : base(element)
        {
            OnPreStart += (Resource resource) => {
                GameServer.HandlePreStart(resource);
                resource.HandlePreStart();
            };
            OnStart += (Resource resource) => {
                GameServer.HandleStart(resource);
                resource.HandleStart();
            };
            OnStop += (Resource resource, bool wasDeleted) => {
                GameServer.HandleStop(resource, wasDeleted);
                resource.HandleStop(wasDeleted);
            };
        }

        #pragma warning disable 67

        internal delegate void OnPreStartHandler(Resource resource);
        internal event OnPreStartHandler OnPreStart;

        internal delegate void OnStartHandler(Resource resource);
        internal event OnStartHandler OnStart;

        internal delegate void OnStopHandler(Resource resource, bool wasDeleted);
        internal event OnStopHandler OnStop;

        #pragma warning restore 67

    }
}
