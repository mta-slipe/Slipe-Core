using Slipe.MtaDefinitions;
using Slipe.Server.Peds;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.IO
{
    /// <summary>
    /// Represents a single command handler
    /// </summary>
    public class CommandHandler
    {
        private Action<Player, string, string[]> callback;
        private Action<string, string[]> consoleCallback;
        private string command;

        /// <summary>
        /// Adds a command handler to be used by players
        /// </summary>
        /// <param name="command"></param>
        /// <param name="callback"></param>
        /// <param name="restricted"></param>
        /// <param name="caseSensitive"></param>
        public CommandHandler(string command, Action<Player, string, string[]> callback, bool restricted = false, bool caseSensitive = true)
        {
            this.command = command;
            this.callback = callback;
            MtaServer.AddCommandHandler(command, CommandHandlerCallback, restricted, caseSensitive);
        }

        /// <summary>
        /// Adds a command handler to be used by the console
        /// </summary>
        /// <param name="command"></param>
        /// <param name="consoleCallback"></param>
        /// <param name="restricted"></param>
        /// <param name="caseSensitive"></param>
        public CommandHandler(string command, Action<string, string[]> consoleCallback, bool restricted = false, bool caseSensitive = true)
        {
            this.consoleCallback = consoleCallback;
            MtaServer.AddCommandHandler(command, CommandHandlerCallback, restricted, caseSensitive);
        }

        private void CommandHandlerCallback(MtaElement element, string command, string[] parameters)
        {
            if (MtaShared.GetElementType(element) == "console")
            {
                this.consoleCallback?.Invoke(command, parameters);
            } else
            {
                this.callback?.Invoke(element == null ? null : (Player)ElementManager.Instance.GetElement(element), command, parameters);
            }
        }

        /// <summary>
        /// Executes the command handler in name of the player
        /// </summary>
        /// <param name="player"></param>
        /// <param name="args"></param>
        public void Execute(Player player, string[] args)
        {
            MtaServer.ExecuteCommandHandler(this.command, player.MTAElement, string.Join(" ", args));
        }

        /// <summary>
        /// Executes the command handler in name of the player
        /// </summary>
        /// <param name="player"></param>
        /// <param name="command"></param>
        /// <param name="args"></param>
        public static void Execute(Player player, string command, string[] args)
        {
            MtaServer.ExecuteCommandHandler(command, player.MTAElement, string.Join(" ", args));
        }
    }
}
