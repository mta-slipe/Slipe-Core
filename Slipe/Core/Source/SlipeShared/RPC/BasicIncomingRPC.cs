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

        public BasicIncomingRpc(dynamic value)
        {
            this.x = (int)value.x;
            this.name = (string)value.name;
            this.element = Slipe.Shared.Elements.ElementManager.Instance.GetElement(value.element);
        }
    }
}
