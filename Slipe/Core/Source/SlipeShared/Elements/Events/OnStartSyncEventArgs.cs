using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Peds;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Shared.Elements.Events
{
    public class OnStartSyncEventArgs
    {
        /// <summary>
        /// The new player that started syncing this element
        /// </summary>
        public SharedPed NewSyncer { get; }

        internal OnStartSyncEventArgs(MtaElement newSyncer)
        {
            NewSyncer = ElementManager.Instance.GetElement<SharedPed>(newSyncer);
        }
    }
}
