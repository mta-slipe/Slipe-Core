using Slipe.MtaDefinitions;
using Slipe.Server.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Game.Events
{
    public class OnStartEventArgs
    {
        /// <summary>
        /// The resource that was started
        /// </summary>
        public Resource Resource { get; }

        internal OnStartEventArgs(MtaResource resource)
        {
            Resource = Resource.Get(resource);
        }
    }
}
