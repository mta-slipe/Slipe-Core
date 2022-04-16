using SlipeLua.MtaDefinitions;
using SlipeLua.Server.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Game.Events
{
    public class OnStopEventArgs
    {
        /// <summary>
        /// The resource that was stopped
        /// </summary>
        public Resource Resource { get; }

        internal OnStopEventArgs(MtaResource resource)
        {
            Resource = Resource.Get(resource);
        }
    }
}
