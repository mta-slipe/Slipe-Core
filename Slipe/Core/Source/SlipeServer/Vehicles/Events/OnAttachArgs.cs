using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Vehicles.Events
{
    public class OnAttachArgs
    {
        /// <summary>
        /// The truck the trailer is attached to
        /// </summary>
        public Vehicle Truck { get; }

        internal OnAttachArgs(Vehicle truck)
        {
            Truck = truck;
        }
    }
}
