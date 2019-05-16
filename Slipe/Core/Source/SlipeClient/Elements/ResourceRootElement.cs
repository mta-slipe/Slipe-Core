using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Elements
{
    [DefaultElementClass(ElementType.Resource)]
    public class ResourceRootElement : Element
    {
        public ResourceRootElement(MtaElement element) : base(element)
        {

        }
    }
}
