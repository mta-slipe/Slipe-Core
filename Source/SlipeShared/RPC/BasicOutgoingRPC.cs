using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.RPC
{
    public class BasicOutgoingRPC : IRPC
    {
        public string name;
        public int x;
        public Element element;

        public BasicOutgoingRPC(string name, int x, Element element)
        {
            this.name = name;
            this.x = x;
            this.element = element;
        }
    }
}
}
