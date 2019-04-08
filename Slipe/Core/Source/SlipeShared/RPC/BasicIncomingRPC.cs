using Slipe.Shared.Elements;
using Slipe.Shared.Rpc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Rpc
{
    public class BasicIncomingRpc : IRpc
    {
        public string name;
        public int x;
        public Element element;

        public BasicIncomingRpc(object value)
        {
            /*
            [[
            this.x = System.cast(System.Int32, value.x)
            this.name = System.cast(System.String, value.name)
            this.element = Slipe.Shared.ElementManager:getInstance():GetElement(value.element)
            ]]
            */
        }
    }
}
