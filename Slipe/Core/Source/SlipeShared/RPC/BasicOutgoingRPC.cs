using Slipe.MTADefinitions;
using Slipe.Shared.Elements;
using Slipe.Shared.Rpc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Rpc
{
    public class BasicOutgoingRpc : IRpc
    {
        public string name;
        public int x;
        public MTAElement element;

        public BasicOutgoingRpc(string name, int x, Element element)
        {
            this.name = name;
            this.x = x;
            this.element = element.MTAElement;
        }
    }
}
