using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Weapons.Events
{
    public class OnCreatedEventArgs
    {
        /// <summary>
        /// The creator
        /// </summary>
        public PhysicalElement Creator { get; }

        internal OnCreatedEventArgs(MtaElement element)
        {
            Creator = ElementManager.Instance.GetElement<PhysicalElement>(element);
        }
    }
}
