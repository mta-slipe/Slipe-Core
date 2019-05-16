using Slipe.MtaDefinitions;
using Slipe.Shared.Peds;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Elements.Events
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
