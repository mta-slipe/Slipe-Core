using SlipeLua.MtaDefinitions;
using SlipeLua.Server.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Game.Events
{
    public class OnPreStartEventArgs
    {
        /// <summary>
        /// The resource that was started
        /// </summary>
        public Resource Resource { get; }

        internal OnPreStartEventArgs(MtaResource resource)
        {
            Resource = Resource.Get(resource);
        }
    }
}
