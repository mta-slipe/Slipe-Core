using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Vehicles.Events
{
    public class OnDetachEventArgs
    {
        /// <summary>
        /// The truck the trailer is detached from
        /// </summary>
        public Vehicle Truck { get; }

        internal OnDetachEventArgs(MtaElement truck)
        {
            Truck = ElementManager.Instance.GetElement<Vehicle>(truck);
        }
    }
}
