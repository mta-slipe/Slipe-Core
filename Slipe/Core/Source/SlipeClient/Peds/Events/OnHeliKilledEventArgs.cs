using Slipe.Client.Vehicles;
using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Peds.Events
{
    public class OnHeliKilledEventArgs
    {
        /// <summary>
        /// The helicopter responsible
        /// </summary>
        public Helicopter ResponsibleHelicopter { get; }

        internal OnHeliKilledEventArgs(MtaElement element)
        {
            ResponsibleHelicopter = ElementManager.Instance.GetElement<Helicopter>(element);
        }
    }
}
