using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Shared.Rpc
{
    public class AsyncRpc: IRpc
    {
        public ClientRpcFailedAction OnClientRpcFailed { get; set; }

        public string Identifier { get; set; }
        public IRpc Rpc { get; set; }

        public AsyncRpc()
        {

        }

        public AsyncRpc(string identifier, IRpc rpc)
        {
            Identifier = identifier;
            Rpc = rpc;
        }

        public void Parse(dynamic value)
        {
            this.Identifier = value.Identifier;
            this.Rpc = value.Rpc;
        }
    }
}
