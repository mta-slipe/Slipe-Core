using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Peds.Events
{
    public class OnStuntStartEventArgs
    {
        /// <summary>
        /// The type of stunt the player is starting to perform. 
        /// </summary>
        public string StuntType { get; }

        internal OnStuntStartEventArgs(dynamic t)
        {
            StuntType = (string)t;
        }
    }
}
