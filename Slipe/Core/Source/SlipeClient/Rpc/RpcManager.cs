using SlipeLua.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using SlipeLua.Shared.Elements;
using SlipeLua.Client.Elements;
using SlipeLua.Shared.Rpc;
using SlipeLua.Client.IO;
using System.Threading.Tasks;

namespace SlipeLua.Client.Rpc
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
        private readonly Dictionary<string, List<RegisteredRpc>> registeredAsyncRPCs;

        private int asyncRpcIndex;

        private RpcManager()
        {
            this.asyncRpcIndex = 0;
            registeredRPCs = new Dictionary<string, List<RegisteredRpc>>();
            registeredAsyncRPCs = new Dictionary<string, List<RegisteredRpc>>();

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
                } else if (registeredAsyncRPCs.ContainsKey(eventName))
                {
                    var registeredRpcs = registeredAsyncRPCs[eventName];

                    foreach (var registeredRpc in registeredRpcs)
                    {
                        var method = registeredRpc.callback;

                        AsyncRpc asyncRpc = Activator.CreateInstance<AsyncRpc>();
                        asyncRpc.Parse(p1);

                        method.Invoke(asyncRpc);
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

        public Task<TResponseRpc> TriggerAsyncRpc<TResponseRpc>(string key, IRpc argument)
             where TResponseRpc : IRpc
        {
            int tickCount = MtaShared.GetTickCount();
            string responseKey = $"response-{key}";

            Task<TResponseRpc> task = null;
            Action<AsyncRpc> callback = null;

            this.asyncRpcIndex++;
            string identifier = $"{this.asyncRpcIndex}";

            /*
            [[
                local asyncCallback
                callback = function(parameters)
                    if (parameters.Identifier == identifier) then
                        local asyncRpc = System.cast(SlipeSharedRpc.AsyncRpc, parameters)
                        local arguments = System.cast(TResponseRpc, System.Activator.CreateInstance(System.typeof(TResponseRpc)))
                        arguments:Parse(asyncRpc.Rpc)

                        asyncCallback(arguments)
                    end
                end

                task, asyncCallback = System.Task.Callback(function(responseRpc)
                    this.registeredRPCs:get(responseKey):Remove(callback)
                    return responseRpc;
                end)
            ]]
            */

            this.RegisterRPC(responseKey, callback);

            MtaClient.TriggerServerEvent(key, Element.Root.MTAElement, new AsyncRpc(identifier, argument));

            return task;
        }


        /// <summary>
        /// Register an async RPC
        /// </summary>
        public void RegisterAsyncRPC<ResponseRpc, RequestRpc>(string key, Func<RequestRpc, ResponseRpc> callback)
            where ResponseRpc : IRpc where RequestRpc : IRpc
        {
            if (!registeredAsyncRPCs.ContainsKey(key))
            {
                registeredAsyncRPCs[key] = new List<RegisteredRpc>();
                MtaShared.AddEvent(key, true);
                Element.Root.ListenForEvent(key);
            }

            string responseKey = $"response-{key}";
            registeredAsyncRPCs[key].Add(new RegisteredRpc((parameters) =>
            {
                var asyncRpc = (AsyncRpc)parameters;
                RequestRpc arguments = (RequestRpc)Activator.CreateInstance(typeof(RequestRpc));
                arguments.Parse(asyncRpc.Rpc);

                var result = callback.Invoke(arguments);
                this.TriggerRPC(responseKey, new AsyncRpc(asyncRpc.Identifier, result));
            }, typeof(AsyncRpc)));
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
