using Slipe.MTADefinitions;
using Slipe.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client
{
    /// <summary>
    /// Represents a single command handler
    /// </summary>
    public class CommandHandler
    {
        private Action<string, string[]> callback;

        /// <summary>
        /// Adds a command handler to be used by players
        /// </summary>
        /// <param name="command"></param>
        /// <param name="callback"></param>
        /// <param name="restricted"></param>
        /// <param name="caseSensitive"></param>
        public CommandHandler(string command, Action<string, string[]> callback, bool restricted = false, bool caseSensitive = true)
        {
            this.callback = callback;
            MTAClient.AddCommandHandler(command, CommandHandlerCallback, caseSensitive);
        }

        private void CommandHandlerCallback(string command, string[] parameters)
        {
            this.callback?.Invoke(command, parameters);
        }
    }
}
