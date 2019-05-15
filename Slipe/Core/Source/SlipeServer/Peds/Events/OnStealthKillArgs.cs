using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnStealthKillArgs
    {
        /// <summary>
        /// The victim of the stealth kill
        /// </summary>
        public Ped Victim { get; }

        internal OnStealthKillArgs(Ped victim)
        {
            Victim = victim;
        }
    }
}
