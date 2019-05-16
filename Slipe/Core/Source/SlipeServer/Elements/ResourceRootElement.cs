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
        public ResourceRootElement(MtaElement element) : base(element) { }

    }
}
