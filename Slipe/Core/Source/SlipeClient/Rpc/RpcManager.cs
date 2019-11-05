using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Slipe.Shared.Elements;
using Slipe.Client.Elements;
using Slipe.Shared.Rpc;
using Slipe.Client.IO;

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

        private readonly Dictionary<string, List<RegisteredRpc>> registeredRPCs;

        private RpcManager()
        {
            registeredRPCs = new Dictionary<string, List<RegisteredRpc>>();

            RootElement.OnMiscelaniousEvent += (eventName, source, p1, p2, p3, p4, p5, p6, p7, p8) =>
            {
                if (registeredRPCs.ContainsKey(eventName))
                {
                    var registeredRpcs = registeredRPCs[eventName];

                    foreach(var registeredRpc in registeredRpcs)
                    {
                        var method = registeredRpc.callback;

                        IRpc rpc = (IRpc)Activator.CreateInstance(registeredRpc.type);
                        rpc.Parse(p1);
                        method.Invoke(rpc);
                    }
                }
            };
        }

        /// <summary>
        /// Register an RPC
        /// </summary>
        public void RegisterRPC<CallbackType>(string key, Action<CallbackType> callback) where CallbackType: IRpc
        {
            if (!registeredRPCs.ContainsKey(key))
            {
                registeredRPCs[key] = new List<RegisteredRpc>();
                MtaShared.AddEvent(key, true);
                Element.Root.ListenForEvent(key);
            }
            registeredRPCs[key].Add(new RegisteredRpc((parameters) =>
            {
                callback((CallbackType)parameters);
            }, typeof(CallbackType)));
        }

        /// <summary>
        /// Trigger an RPC
        /// </summary>
        public void TriggerRPC(string key, IRpc argument)
        {
            MtaClient.TriggerServerEvent(key, Element.Root.MTAElement, argument);
        }

        /// <summary>
        /// Trigger an RPC with limited bandwidth
        /// </summary>
        public void TriggerLatentRPC(string key, int bandwidth, IRpc argument, bool persists = false)
        {
            MtaClient.TriggerLatentServerEvent(key, bandwidth, persists, Element.Root.MTAElement, argument);
        }
    }

    struct RegisteredRpc
    {
        public Type type;
        public Action<IRpc> callback;

        public RegisteredRpc(Action<IRpc> callback, Type type)
        {
            this.callback = callback;
            this.type = type;
        }
    }
}
