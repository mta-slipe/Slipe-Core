using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.RPC
{
    public class SingleElementIncomingRPC : IRPC
    {
        public Element element;

        public SingleElementIncomingRPC(object value)
        {
            /*
            [[
            this.element = Slipe.Shared.ElementManager.GetElement(value.element.MTAElement)
            ]]
            */
        }
    }
}
