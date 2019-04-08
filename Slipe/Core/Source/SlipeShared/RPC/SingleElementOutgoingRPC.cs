using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.RPC
{
    public class SingleElementOutgoingRPC : IRPC
    {
        public Element element;

        public SingleElementOutgoingRPC(Element element)
        {
            this.element = element;
        }
    }
}
