using SlipeLua.Client.Vehicles;
using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Peds.Events
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
