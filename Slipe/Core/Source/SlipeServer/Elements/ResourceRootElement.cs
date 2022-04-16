using SlipeLua.MtaDefinitions;
using SlipeLua.Server.Game;
using SlipeLua.Server.Resources;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Elements
{
    [DefaultElementClass(ElementType.Resource)]
    public class ResourceRootElement: Element
    {
        public ResourceRootElement(MtaElement element) : base(element) { }

    }
}
