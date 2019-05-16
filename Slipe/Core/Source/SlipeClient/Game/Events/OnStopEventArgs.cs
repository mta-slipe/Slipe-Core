using Slipe.Client.Resources;
using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Game.Events
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
