using SlipeLua.Client.Resources;
using SlipeLua.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Game.Events
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
