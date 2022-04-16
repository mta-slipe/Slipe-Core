using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Peds.Events
{
    public class OnContactEventArgs
    {
        /// <summary>
        /// The element the player was previously standing on (can be null)
        /// </summary>
        public PhysicalElement PreviousElement { get; }

        /// <summary>
        /// The new element the player is standing on (can be null)
        /// </summary>
        public PhysicalElement NewElement { get; }

        internal OnContactEventArgs(MtaElement previousElement, MtaElement newElement)
        {
            PreviousElement = ElementManager.Instance.GetElement<PhysicalElement>(previousElement);
            NewElement = ElementManager.Instance.GetElement<PhysicalElement>(newElement);
        }
    }
}
