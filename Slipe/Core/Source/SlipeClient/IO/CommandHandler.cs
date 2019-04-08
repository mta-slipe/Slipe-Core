using Slipe.MtaDefinitions;
using Slipe.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.IO
{

    /// <summary>
    /// Represents a single command handler
    /// </summary>
    public class CommandHandler
    {
        private Action<string, string[]> callback;
        private string command;

        /// <summary>
        /// Adds a command handler to be used by players
        /// </summary>
        /// <param name="command"></param>
        /// <param name="callback"></param>
        /// <param name="restricted"></param>
        /// <param name="caseSensitive"></param>
        public CommandHandler(string command, Action<string, string[]> callback, bool restricted = false, bool caseSensitive = true)
        {
            this.command = command;
            this.callback = callback;
            MtaClient.AddCommandHandler(command, CommandHandlerCallback, caseSensitive);
        }

        private void CommandHandlerCallback(string command, string[] parameters)
        {
            this.callback?.Invoke(command, parameters);
        }

        /// <summary>
        /// Executes the command handler
        /// </summary>
        /// <param name="args"></param>
        public void Execute(string[] args)
        {
            MtaClient.ExecuteCommandHandler(this.command, string.Join(" ", args));
        }

        /// <summary>
        /// Executes the command handler
        /// </summary>
        /// <param name="command"></param>
        /// <param name="args"></param>
        public static void Execute(string command, string[] args)
        {
            MtaClient.ExecuteCommandHandler(command, string.Join(" ", args));
        }
    }
}
