using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnTargetArgs
    {
        /// <summary>
        /// The element that is targeted, can be null
        /// </summary>
        public PhysicalElement Target { get; }

        internal OnTargetArgs(PhysicalElement target)
        {
            Target = target;
        }
    }
}
