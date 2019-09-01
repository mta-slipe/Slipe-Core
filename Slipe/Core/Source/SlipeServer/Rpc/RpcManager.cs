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

        private Dictionary<string, RegisteredRpc> RegisteredRpcs;
        private Dictionary<Player, List<QueuedRpc>> QueuedRpcs;

        private RpcManager()
        {
            MtaShared.AddEvent("slipe-client-ready-rpc", true);
            RegisteredRpcs = new Dictionary<string, RegisteredRpc>();
            QueuedRpcs = new Dictionary<Player, List<QueuedRpc>>();

            RootElement.OnMiscelaniousEvent += (eventName, source, p1, p2, p3, p4, p5, p6, p7, p8) =>
            {
                if (RegisteredRpcs.ContainsKey(eventName))
                {
                    Player player = ElementManager.Instance.GetElement<Player>(source);

                    var registeredRpc = RegisteredRpcs[eventName];

                    var method = registeredRpc.callback;

                    IRpc rpc = (IRpc)Activator.CreateInstance(registeredRpc.type);
                    rpc.Parse(p1);
                    method.Invoke(player, rpc);
                }
                else if(eventName == "slipe-client-ready-rpc")
                {
                    Player player = ElementManager.Instance.GetElement<Player>(source);
                    List<QueuedRpc> queuedRpcList;
                    QueuedRpcs.TryGetValue(player, out queuedRpcList);
                    if(queuedRpcList != null)
                    {
                        foreach(QueuedRpc queuedRpc in queuedRpcList)
                        {
                            if (queuedRpc.bandwidth != -1)
                                TriggerLatentRPC(player, queuedRpc.key, queuedRpc.bandwidth, queuedRpc.rpc, queuedRpc.persists);
                            else
                                TriggerRPC(player, queuedRpc.key, queuedRpc.rpc);
                        }
                        QueuedRpcs.Remove(player);
                    }
                }
            };
        }

        /// <summary>
        /// Register an RPC
        /// </summary>
        public void RegisterRPC<CallbackType>(string key, Action<Player, CallbackType> callback)
        {
            RegisteredRpcs[key] = new RegisteredRpc((player, parameters) =>
            {
                callback.Invoke(player, (CallbackType)parameters);
            }, typeof(CallbackType));
            MtaShared.AddEvent(key, true);
            Element.Root.ListenForEvent(key);
        }

        private void QueueRpc(Player target, string key, IRpc argument, int bandwidth = -1, bool persists = false)
        {
            if (!QueuedRpcs.ContainsKey(target))
                QueuedRpcs[target] = new List<QueuedRpc>();

            QueuedRpcs[target].Add(new QueuedRpc(key, argument, bandwidth, persists));
        }

        /// <summary>
        /// Trigger an RPC on a player
        /// </summary>
        public void TriggerRPC(Player target, string key, IRpc argument)
        {
            if(!target.IsReadyForIncomingRequests && argument.OnClientRpcFailed == ClientRpcFailedAction.Queue)
                QueueRpc(target, key, argument);
            else
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
            if (!target.IsReadyForIncomingRequests && argument.OnClientRpcFailed == ClientRpcFailedAction.Queue)
                QueueRpc(target, key, argument, bandwidth, persists);
            else
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

    struct QueuedRpc
    {
        public string key;
        public IRpc rpc;
        public bool persists;
        public int bandwidth;

        public QueuedRpc(string key, IRpc rpc, int bandwidth, bool persists)
        {
            this.key = key;
            this.rpc = rpc;
            this.bandwidth = bandwidth;
            this.persists = persists;
        }
    }
}
