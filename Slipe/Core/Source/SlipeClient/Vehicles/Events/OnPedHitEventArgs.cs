using Slipe.Client.Peds;
using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Vehicles.Events
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
