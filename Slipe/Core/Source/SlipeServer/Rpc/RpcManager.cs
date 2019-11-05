using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Elements;
using Slipe.Server.Peds;
using Slipe.Server.Elements;
using Slipe.Shared.Rpc;
using Slipe.Server.IO;

namespace Slipe.Server.Rpc
{
    /// <summary>
    /// Manager class that handles RPC's between server and clients
    /// </summary>
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
                    Player player = ElementManager.Instance.GetElement<Player>(source);

                    var registeredRpcs = registeredRPCs[eventName];

                    foreach (var registeredRpc in registeredRpcs)
                    {
                        var method = registeredRpc.callback;

                        IRpc rpc = (IRpc)Activator.CreateInstance(registeredRpc.type);
                        rpc.Parse(p1);
                        method.Invoke(player, rpc);
                    }
                }
            };
        }

        /// <summary>
        /// Register an RPC
        /// </summary>
        public void RegisterRPC<CallbackType>(string key, Action<Player, CallbackType> callback)
        {
            if (!registeredRPCs.ContainsKey(key))
            {
                registeredRPCs[key] = new List<RegisteredRpc>();
                MtaShared.AddEvent(key, true);
                Element.Root.ListenForEvent(key);
            }
            registeredRPCs[key].Add(new RegisteredRpc((player, parameters) =>
            {
                callback.Invoke(player, (CallbackType)parameters);
            }, typeof(CallbackType)));
        }

        /// <summary>
        /// Trigger an RPC on a player
        /// </summary>
        public void TriggerRPC(Player target, string key, IRpc argument)
        {
            MtaServer.TriggerClientEvent(target.MTAElement, key, Element.Root.MTAElement, argument);
        }

        /// <summary>
        /// Trigger an RPC
        /// </summary>
        public void TriggerRPC(string key, IRpc argument)
        {
            MtaServer.TriggerClientEvent(Element.Root.MTAElement, key, Element.Root.MTAElement, argument);
        }

        /// <summary>
        /// Trigger an RPC with limited bandwidth
        /// </summary>
        public void TriggerLatentRPC(Player target, string key, int bandwidth, IRpc argument, bool persists = false)
        {
            MtaServer.TriggerLatentClientEvent(target.MTAElement, key, bandwidth, persists, Element.Root.MTAElement, argument);
        }

        /// <summary>
        /// Trigger an RPC with limited bandwidth
        /// </summary>
        public void TriggerLatentRPC(string key, int bandwidth, IRpc argument, bool persists = false)
        {
            MtaServer.TriggerLatentClientEvent(Element.Root.MTAElement, key, bandwidth, persists, Element.Root.MTAElement, argument);
        }
    }

    struct RegisteredRpc
    {
        public Type type;
        public Action<Player, IRpc> callback;

        public RegisteredRpc(Action<Player, IRpc> callback, Type type)
        {
            this.callback = callback;
            this.type = type;
        }
    }
}
