using Slipe.Shared.Peds;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Elements.Events
{
    public class OnStartSyncArgs
    {
        /// <summary>
        /// The new player that started syncing this element
        /// </summary>
        public SharedPed NewSyncer { get; }

        internal OnStartSyncArgs(SharedPed newSyncer)
        {
            NewSyncer = newSyncer;
        }
    }
}
