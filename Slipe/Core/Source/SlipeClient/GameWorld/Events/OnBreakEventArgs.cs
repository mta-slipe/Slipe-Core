using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.GameWorld.Events
{
    public class OnBreakEventArgs
    {
        /// <summary>
        /// The responsible element for breaking this WorldObject
        /// </summary>
        public PhysicalElement Attacker { get; }

        /// <summary>
        /// The amount of health lost
        /// </summary>
        public float Loss { get; }

        internal OnBreakEventArgs(dynamic loss, MtaElement target)
        {
            Attacker = ElementManager.Instance.GetElement<PhysicalElement>(target);
            Loss = (float)loss;
        }
    }
}
