using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Vehicles.Events
{
    public class OnAttachEventArgs
    {
        /// <summary>
        /// The truck the trailer is attached to
        /// </summary>
        public Vehicle Truck { get; }

        internal OnAttachEventArgs(MtaElement truck)
        {
            Truck = ElementManager.Instance.GetElement<Vehicle>(truck);
        }
    }
}
