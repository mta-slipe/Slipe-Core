using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Shared.Rpc
{
    public interface IRpc
    {
        ClientRpcFailedAction OnClientRpcFailed { get; set; }
        void Parse(dynamic value);
    }
}
