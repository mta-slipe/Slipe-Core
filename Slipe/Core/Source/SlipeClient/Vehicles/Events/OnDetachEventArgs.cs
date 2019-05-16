using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Vehicles.Events
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
