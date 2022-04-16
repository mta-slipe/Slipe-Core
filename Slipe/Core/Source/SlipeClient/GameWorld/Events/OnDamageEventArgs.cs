using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.GameWorld.Events
{
    public class OnDamageEventArgs
    {
        /// <summary>
        /// The responsible element for damaging this WorldObject
        /// </summary>
        public PhysicalElement Attacker { get; }

        internal OnDamageEventArgs(MtaElement target)
        {
            Attacker = ElementManager.Instance.GetElement<PhysicalElement>(target);
        }
    }
}
