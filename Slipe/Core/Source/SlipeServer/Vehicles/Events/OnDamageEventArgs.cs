using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Vehicles.Events
{
    public class OnDamageEventArgs
    {
        /// <summary>
        /// The damage taken
        /// </summary>
        public float Loss { get; }

        internal OnDamageEventArgs(dynamic loss)
        {
            Loss = (float) loss;
        }
    }
}
