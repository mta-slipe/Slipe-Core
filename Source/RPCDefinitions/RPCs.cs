using Slipe.MtaDefinitions;
using Slipe.Shared;
using System;
using System.Diagnostics;
using Slipe.Shared.Rpc;

namespace RPCDefinitions
{
    public class TestRPC: IRpc
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
