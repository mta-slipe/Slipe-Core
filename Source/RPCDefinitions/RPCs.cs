using Slipe.MTADefinitions;
using Slipe.Shared;
using System;
using System.Diagnostics;

namespace RPCDefinitions
{
    public class TestRPC: IRPC
    {
        public string name;
        public int x;



        public TestRPC(string name, int x)
        {
            this.name = name;
            this.x = x;
        }

        public TestRPC(object value)
        {
            /*
            [[
            this.x = System.cast(System.Int32, value.x)
            this.name = System.cast(System.String, value.name)
            ]]
            */
        }
    }
}
