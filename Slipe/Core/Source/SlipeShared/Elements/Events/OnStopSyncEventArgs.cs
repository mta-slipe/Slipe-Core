using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Peds;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Shared.Elements.Events
{
    public class OnStopSyncEventArgs
    {
        /// <summary>
        /// The old player that stopped syncing this element
        /// </summary>
        public SharedPed OldSyncer { get; }

        internal OnStopSyncEventArgs(MtaElement oldSyncer)
        {
            OldSyncer = ElementManager.Instance.GetElement<SharedPed>(oldSyncer);
        }
    }
}
