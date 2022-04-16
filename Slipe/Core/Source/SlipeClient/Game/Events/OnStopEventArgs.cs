using SlipeLua.Client.Resources;
using SlipeLua.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Game.Events
{
    public class OnStopEventArgs
    {
        /// <summary>
        /// The stopped resource
        /// </summary>
        Resource Resource { get; }

        internal OnStopEventArgs(MtaResource resource)
        {
            Resource = Resource.Get(resource);
        }
    }
}
