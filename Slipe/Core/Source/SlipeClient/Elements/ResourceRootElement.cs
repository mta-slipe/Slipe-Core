using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Elements
{
    [DefaultElementClass(ElementType.Resource)]
    public class ResourceRootElement : Element
    {
        public ResourceRootElement(MtaElement element) : base(element)
        {

        }
    }
}
