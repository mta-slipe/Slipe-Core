using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Rpc
{
    public class SingleElementIncomingRpc : IRpc
    {
        public Element element;

        public SingleElementIncomingRpc(object value)
        {
            /*
            [[
            this.element = Slipe.Shared.ElementManager.GetElement(value.element.MTAElement)
            ]]
            */
        }
    }
}
