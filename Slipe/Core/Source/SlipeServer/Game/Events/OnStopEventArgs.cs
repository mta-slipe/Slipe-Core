using Slipe.MtaDefinitions;
using Slipe.Server.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Game.Events
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
