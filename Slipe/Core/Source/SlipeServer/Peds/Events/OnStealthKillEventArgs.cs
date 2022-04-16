using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Peds.Events
{
    public class OnStealthKillEventArgs
    {
        /// <summary>
        /// The victim of the stealth kill
        /// </summary>
        public Ped Victim { get; }

        internal OnStealthKillEventArgs(MtaElement victim)
        {
            Victim = ElementManager.Instance.GetElement<Ped>(victim);
        }
    }
}
