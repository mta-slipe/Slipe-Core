using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Rpc
{
    public class EmptyRpc: IRpc
    {
        private ClientRpcFailedAction rpcFailedAction;
        public ClientRpcFailedAction OnClientRpcFailed
        {
            get
            {
                return rpcFailedAction;
            }
            set
            {
                rpcFailedAction = value;
            }
        }

        public EmptyRpc()
        {
            rpcFailedAction = ClientRpcFailedAction.Ignore;
        }

        public void Parse(dynamic value)
        {

        }
    }
}
