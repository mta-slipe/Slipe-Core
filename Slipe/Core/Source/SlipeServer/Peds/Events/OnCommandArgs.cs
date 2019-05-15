using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnCommandArgs
    {
        /// <summary>
        /// The command that the player entered
        /// </summary>
        public string Command { get; }

        internal OnCommandArgs(string command)
        {
            Command = command;
        }
    }
}
