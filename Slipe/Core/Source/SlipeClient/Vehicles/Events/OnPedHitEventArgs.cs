using SlipeLua.Client.Peds;
using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Vehicles.Events
{
    public class OnPedHitEventArgs
    {
        /// <summary>
        /// The ped that was hit
        /// </summary>
        public Ped Ped { get; }

        internal OnPedHitEventArgs(MtaElement ped)
        {
            Ped = ElementManager.Instance.GetElement<Ped>(ped);
        }
    }
}
