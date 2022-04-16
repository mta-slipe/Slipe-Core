using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Peds.Events
{
    public class OnCommandEventArgs
    {
        /// <summary>
        /// The command that the player entered
        /// </summary>
        public string Command { get; }

        internal OnCommandEventArgs(dynamic command)
        {
            Command = (string) command;
        }
    }
}
