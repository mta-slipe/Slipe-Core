using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Elements;
using Slipe.Server.Peds;
using Slipe.Server.Elements;

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

        private Dictionary<string, Action<Player, object>> RegisteredRPCs;

        private RpcManager()
        {
            RegisteredRPCs = new Dictionary<string, Action<Player, object>>();

            RootElement.OnMiscelaniousEvent += (eventName, source, p1, p2, p3, p4, p5, p6, p7, p8) =>
            {
                if (RegisteredRPCs.ContainsKey(eventName))
                {
                    Player player = ElementManager.Instance.GetElement<Player>(source);
                    RegisteredRPCs[eventName].Invoke(player, p1);
                }
            };
        }

        /// <summary>
        /// Register an RPC
        /// </summary>
        public void RegisterRPC<CallbackType>(string key, Action<Player, CallbackType> callback)
        {
            RegisteredRPCs[key] = (player, parameters) =>
            {
                /*
                [[
                    callback(player, CallbackType(parameters))
                ]]
                 */
            };
            MtaShared.AddEvent(key, true);
            Element.Root.ListenForEvent(key);
        }

        /// <summary>
        /// Trigger an RPC on a player
        /// </summary>
        public void TriggerRPC(Player target, string key, object argument)
        {
            MtaServer.TriggerClientEvent(target.MTAElement, key, Element.Root.MTAElement, argument);
        }

        /// <summary>
        /// Trigger an RPC
        /// </summary>
        public void TriggerRPC(string key, object argument)
        {
            MtaServer.TriggerClientEvent(Element.Root.MTAElement, key, Element.Root.MTAElement, argument);
        }

        /// <summary>
        /// Trigger an RPC with limited bandwidth
        /// </summary>
        public void TriggerLatentRPC(Player target, string key, int bandwidth, object argument, bool persists = false)
        {
            MtaServer.TriggerLatentClientEvent(target.MTAElement, key, bandwidth, persists, Element.Root.MTAElement, argument);
        }

        /// <summary>
        /// Trigger an RPC with limited bandwidth
        /// </summary>
        public void TriggerLatentRPC(string key, int bandwidth, object argument, bool persists = false)
        {
            MtaServer.TriggerLatentClientEvent(Element.Root.MTAElement, key, bandwidth, persists, Element.Root.MTAElement, argument);
        }
    }
}
