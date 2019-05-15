using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Vehicles.Events
{
    public class OnDamageArgs
    {
        /// <summary>
        /// The damage taken
        /// </summary>
        public float Loss { get; }

        internal OnDamageArgs(float loss)
        {
            Loss = loss;
        }
    }
}
