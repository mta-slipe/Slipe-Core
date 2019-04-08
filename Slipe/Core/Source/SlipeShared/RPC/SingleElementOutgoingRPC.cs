using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Rpc
{
    public class SingleElementOutgoingRpc : IRpc
    {
        public Element element;

        public SingleElementOutgoingRpc(Element element)
        {
            this.element = element;
        }
    }
}
