using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Slipe.Shared.Elements;
using Slipe.Client.Elements;

namespace Slipe.Client.Rpc
{
    public class RpcManager
    {
        private static RpcManager instance;
        public static RpcManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RpcManager();
                }
                return instance;
            }
        }

        private Dictionary<string, Action<object>> RegisteredRPCs;

        private RpcManager()
        {
            RegisteredRPCs = new Dictionary<string, Action<object>>();

            RootElement.OnMiscelaniousEvent += (eventName, source, p1, p2, p3, p4, p5, p6, p7, p8) =>
            {
                Console.WriteLine("CLIENT RPC TRIGGER");
                if (RegisteredRPCs.ContainsKey(eventName))
                {
                    RegisteredRPCs[eventName].Invoke(p1);
                }
            };
        }

        /// <summary>
        /// Register an RPC
        /// </summary>
        public void RegisterRPC<CallbackType>(string key, Action<CallbackType> callback)
        {
            RegisteredRPCs[key] = (parameters) =>
            {
                /*
                [[
                    callback(CallbackType(parameters))
                ]]
                 */
            };
            MtaShared.AddEvent(key, true);
            Element.Root.ListenForEvent(key);
        }

        /// <summary>
        /// Trigger an RPC
        /// </summary>
        public void TriggerRPC(string key, object argument)
        {
            MtaClient.TriggerServerEvent(key, Element.Root.MTAElement, argument);
        }

        /// <summary>
        /// Trigger an RPC with limited bandwidth
        /// </summary>
        public void TriggerLatentRPC(string key, int bandwidth, object argument, bool persists = false)
        {
            MtaClient.TriggerLatentServerEvent(key, bandwidth, persists, Element.Root.MTAElement, argument);
        }
    }
}
