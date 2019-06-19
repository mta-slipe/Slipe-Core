using Slipe.MtaDefinitions;
using Slipe.Server.Peds;
using Slipe.Shared.Elements;
using Slipe.Shared.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.IO
{
    public static class Input
    {
        private static Dictionary<Action<Player, string, KeyState>, Action<MtaElement, string, string>> closures 
            = new Dictionary<Action<Player, string, KeyState>, Action<MtaElement, string, string>>();

        /// <summary>
        /// Binds a key to a command
        /// </summary>
        /// <param name="player"></param>
        /// <param name="key"></param>
        /// <param name="state"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        public static bool BindKey(Player player, string key, KeyState state, string command)
        {
            return MtaServer.BindKey(player.MTAElement, key, state.ToString().ToLower(), command);
        }

        /// <summary>
        /// Unbinds a key from a command
        /// </summary>
        /// <param name="player"></param>
        /// <param name="key"></param>
        /// <param name="state"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        public static bool UnbindKey(Player player, string key, KeyState state, string command = null)
        {
            return MtaServer.UnbindKey(player.MTAElement, key, state.ToString().ToLower(), command);
        }

        /// <summary>
        /// Binds a key to a method
        /// </summary>
        /// <param name="player"></param>
        /// <param name="key"></param>
        /// <param name="state"></param>
        /// <param name="handler"></param>
        /// <returns></returns>
        public static bool BindKey(Player player, string key, KeyState state, Action<Player, string, KeyState> handler)
        {
            Action<MtaElement, string, string> rawClosure = (MtaElement element, string command, string state) =>
            {
                handler((Player)ElementManager.Instance.GetElement(element), command, Enum.Parse<KeyState>(state));
            };
            closures[handler] = rawClosure;
            return MtaServer.BindKey(player.MTAElement, key, state.ToString().ToLower(), rawClosure);
        }

        /// <summary>
        /// Unbinds a key from a method
        /// </summary>
        /// <param name="player"></param>
        /// <param name="key"></param>
        /// <param name="state"></param>
        /// <param name="handler"></param>
        /// <returns></returns>
        public static bool UnbindKey(Player player, string key, KeyState state, Action<Player, string, KeyState> handler)
        {
            if (closures.ContainsKey(handler))
            {
                bool result = MtaServer.UnbindKey(player.MTAElement, key, state.ToString().ToLower(), closures[handler]);
                closures.Remove(handler);
                return result;
            }
            return false;
        }
    }
}
