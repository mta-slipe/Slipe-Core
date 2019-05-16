using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.GameWorld.Events
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
