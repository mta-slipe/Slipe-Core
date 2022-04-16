using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Peds.Events
{
    public class OnTargetEventArgs
    {
        /// <summary>
        /// The element that is targeted, can be null
        /// </summary>
        public PhysicalElement Target { get; }

        internal OnTargetEventArgs(MtaElement target)
        {
            Target = ElementManager.Instance.GetElement<PhysicalElement>(target);
        }
    }
}
