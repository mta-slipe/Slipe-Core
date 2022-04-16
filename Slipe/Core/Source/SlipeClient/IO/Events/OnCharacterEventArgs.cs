using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.IO.Events
{
    public class OnCharacterEventArgs
    {
        /// <summary>
        /// The character that was entered
        /// </summary>
        public string Character { get; }

        internal OnCharacterEventArgs(dynamic character)
        {
            Character = (string)character;
        }
    }
}
