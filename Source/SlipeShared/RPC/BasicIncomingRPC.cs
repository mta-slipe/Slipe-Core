using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.RPC
{
    public class BasicIncomingRPC : IRPC
    {
        public string name;
        public int x;
        public Element element;

        public BasicIncomingRPC(object value)
        {
            /*
            [[
            this.x = System.cast(System.Int32, value.x)
            this.name = System.cast(System.String, value.name)
            this.element = Slipe.Shared.ElementManager.GetElement(value.element.MTAElement)
            ]]
            */
        }
    }
}
