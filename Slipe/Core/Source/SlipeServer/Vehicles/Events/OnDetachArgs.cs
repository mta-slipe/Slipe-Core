using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Vehicles.Events
{
    public class OnDetachArgs
    {
        /// <summary>
        /// The truck the trailer is detached from
        /// </summary>
        public Vehicle Truck { get; }

        internal OnDetachArgs(Vehicle truck)
        {
            Truck = truck;
        }
    }
}
