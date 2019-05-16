using Slipe.Client.Resources;
using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Game.Events
{
    public class OnStartEventArgs
    {
        /// <summary>
        /// The started resource
        /// </summary>
        Resource Resource { get; }

        internal OnStartEventArgs(MtaResource resource)
        {
            Resource = Resource.Get(resource);
        }
    }
}
