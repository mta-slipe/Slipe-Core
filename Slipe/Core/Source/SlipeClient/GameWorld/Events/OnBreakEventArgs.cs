using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.GameWorld.Events
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
