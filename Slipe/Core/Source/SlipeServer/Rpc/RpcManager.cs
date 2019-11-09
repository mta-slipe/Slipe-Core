using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Elements;
using Slipe.Server.Peds;
using Slipe.Server.Elements;
using Slipe.Shared.Rpc;
using Slipe.Server.IO;
using System.Threading.Tasks;

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
        private readonly Dictionary<string, List<RegisteredRpc>> registeredAsyncRPCs;
        private Dictionary<Player, List<QueuedRpc>> QueuedRpcs;

        private int asyncRpcIndex;

        private RpcManager()
        {
            this.asyncRpcIndex = 0;
            QueuedRpcs = new Dictionary<Player, List<QueuedRpc>>();
            registeredRPCs = new Dictionary<string, List<RegisteredRpc>>();
            registeredAsyncRPCs = new Dictionary<string, List<RegisteredRpc>>();

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
                else if (registeredAsyncRPCs.ContainsKey(eventName))
                {
                    Player player = ElementManager.Instance.GetElement<Player>(source);

                    var registeredRpcs = registeredAsyncRPCs[eventName];

                    foreach (var registeredRpc in registeredRpcs)
                    {
                        var method = registeredRpc.callback;

                        AsyncRpc asyncRpc = Activator.CreateInstance<AsyncRpc>();
                        asyncRpc.Parse(p1);

                        method.Invoke(player, asyncRpc);
                    }
                }
            };

            RegisterRPC<EmptyRpc>("slipe-client-ready-rpc", (player, rpc) =>
            {
                List<QueuedRpc> queuedRpcList;
                QueuedRpcs.TryGetValue(player, out queuedRpcList);
                if (queuedRpcList != null)
                {
                    foreach (QueuedRpc queuedRpc in queuedRpcList)
                    {
                        if (queuedRpc.bandwidth != -1)
                            TriggerLatentRPC(player, queuedRpc.key, queuedRpc.bandwidth, queuedRpc.rpc, queuedRpc.persists);
                        else
                            TriggerRPC(player, queuedRpc.key, queuedRpc.rpc);
                    }
                    QueuedRpcs.Remove(player);
                }
            });
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
        /// Trigger an RPC for a specified list of players
        /// </summary>
        /// <param name="targets"></param>
        /// <param name="key"></param>
        /// <param name="argument"></param>
        public void TriggerRPC(List<Player> targets, string key, IRpc argument)
        {
            List<MtaElement> playerElements = new List<MtaElement>();
            foreach(Player player in targets)
            {
                if (player.IsReadyForIncomingRequests)
                    playerElements.Add(player.MTAElement);
                else if (argument.OnClientRpcFailed == ClientRpcFailedAction.Queue)
                    QueueRpc(player, key, argument);
            }
            MtaServer.TriggerClientEvent(playerElements, key, Element.Root.MTAElement, argument);
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

        /// <summary>
        /// Trigger an RPC with limited bandwidth for a specified list of players
        /// </summary>
        /// <param name="targets"></param>
        /// <param name="key"></param>
        /// <param name="argument"></param>
        public void TriggerRPC(List<Player> targets, string key, int bandwidth, IRpc argument, bool persists = false)
        {
            List<MtaElement> playerElements = new List<MtaElement>();
            foreach (Player player in targets)
            {
                if (player.IsReadyForIncomingRequests)
                    playerElements.Add(player.MTAElement);
                else if (argument.OnClientRpcFailed == ClientRpcFailedAction.Queue)
                    QueueRpc(player, key, argument, bandwidth, persists);
            }
            MtaServer.TriggerLatentClientEvent(playerElements, key, bandwidth, persists, Element.Root.MTAElement, argument);
        }

        public Task<TResponseRpc> TriggerAsyncRpc<TResponseRpc>(Player target, string key, IRpc argument)
             where TResponseRpc: IRpc
        {
            int tickCount = MtaShared.GetTickCount();
            string responseKey = $"response-{key}";

            Task<TResponseRpc> task = null;
            Action<Player, AsyncRpc> callback = null;

            this.asyncRpcIndex++;
            string identifier = $"{this.asyncRpcIndex}";

            /*
            [[
                local asyncCallback
                callback = function(player, parameters)
                    if (parameters.Identifier == identifier) then
                        local asyncRpc = System.cast(SlipeSharedRpc.AsyncRpc, parameters)
                        local arguments = System.cast(TResponseRpc, System.Activator.CreateInstance(System.typeof(TResponseRpc)))
                        arguments:Parse(asyncRpc.Rpc)

                        asyncCallback(player, arguments)
                    end
                end

                task, asyncCallback = System.Task.Callback(function(player, responseRpc)
                    this.registeredRPCs:get(responseKey):Remove(callback)
                    return responseRpc;
                end)
            ]]
            */

            this.RegisterRPC(responseKey, callback);

            if (target.IsReadyForIncomingRequests)
            {
                MtaServer.TriggerClientEvent(target.MTAElement, key, Element.Root.MTAElement, new AsyncRpc(identifier, argument));
            }
            else if (argument.OnClientRpcFailed == ClientRpcFailedAction.Queue)
            {
                QueueRpc(target, key, new AsyncRpc(identifier, argument));
            }

            return task;
        }


        /// <summary>
        /// Register an async RPC
        /// </summary>
        public void RegisterAsyncRPC<ResponseRpc, RequestRpc>(string key, Func<Player, RequestRpc, ResponseRpc> callback)
            where ResponseRpc : IRpc where RequestRpc : IRpc
        {
            if (!registeredAsyncRPCs.ContainsKey(key))
            {
                registeredAsyncRPCs[key] = new List<RegisteredRpc>();
                MtaShared.AddEvent(key, true);
                Element.Root.ListenForEvent(key);
            }

            string responseKey = $"response-{key}";
            registeredAsyncRPCs[key].Add(new RegisteredRpc((player, parameters) =>
            {
                var asyncRpc = (AsyncRpc)parameters;
                RequestRpc arguments = (RequestRpc)Activator.CreateInstance(typeof(RequestRpc));
                arguments.Parse(asyncRpc.Rpc);

                var result = callback.Invoke(player, arguments);
                this.TriggerRPC(responseKey, new AsyncRpc(asyncRpc.Identifier, result));
            }, typeof(AsyncRpc)));
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
