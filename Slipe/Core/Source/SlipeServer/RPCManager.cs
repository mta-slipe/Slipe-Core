using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Elements;

namespace Slipe.Server
{
    /// <summary>
    /// Manager class that handles RPC's between server and clients
    /// </summary>
    public class RPCManager
    {
        private static RPCManager instance;
        public static RPCManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RPCManager();
                }
                return instance;
            }
        }

        private Dictionary<string, Action<Player, object>> RegisteredRPCs;

        private RPCManager()
        {
            RegisteredRPCs = new Dictionary<string, Action<Player, object>>();

            Element.OnRootEvent += (string eventName, MTAElement source, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8) =>
            {
                if (RegisteredRPCs.ContainsKey(eventName))
                {
                    Element element = ElementManager.Instance.GetElement(source);
                    Player player = (Player)element;
                    RegisteredRPCs[eventName].Invoke(player, p1);
                }
            };
        }

        /// <summary>
        /// Register an RPC
        /// </summary>
        public void RegisterRPC<CallbackType>(string key, Action<Player, CallbackType> callback)
        {
            RegisteredRPCs[key] = (Player player, object parameters) => {
                /*
                [[
                    callback(player, CallbackType(parameters))
                ]]
                 */
            };
            MTAShared.AddEvent(key, true);
            Element.Root.AddEventHandler(key);
        }

        /// <summary>
        /// Trigger an RPC on a player
        /// </summary>
        public void TriggerRPC(Player target, string key, object argument)
        {
            MTAServer.TriggerClientEvent(target.MTAElement, key, Element.Root.MTAElement, argument);
        }

        /// <summary>
        /// Trigger an RPC
        /// </summary>
        public void TriggerRPC(string key, object argument)
        {
            MTAServer.TriggerClientEvent(Element.Root.MTAElement, key, Element.Root.MTAElement, argument);
        }
    }
}
