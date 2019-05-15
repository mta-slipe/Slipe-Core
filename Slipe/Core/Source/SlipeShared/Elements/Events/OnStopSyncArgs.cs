using Slipe.Shared.Peds;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Elements.Events
{
    public class OnStopSyncArgs
    {
        /// <summary>
        /// The old player that stopped syncing this element
        /// </summary>
        public SharedPed OldSyncer { get; }

        internal OnStopSyncArgs(SharedPed oldSyncer)
        {
            OldSyncer = oldSyncer;
        }
    }
}
