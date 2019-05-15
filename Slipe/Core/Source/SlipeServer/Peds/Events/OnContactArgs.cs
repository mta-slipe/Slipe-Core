using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnContactArgs
    {
        /// <summary>
        /// The element the player was previously standing on (can be null)
        /// </summary>
        public PhysicalElement PreviousElement { get; }

        /// <summary>
        /// The new element the player is standing on (can be null)
        /// </summary>
        public PhysicalElement NewElement { get; }

        internal OnContactArgs(PhysicalElement previousElement, PhysicalElement newElement)
        {
            PreviousElement = previousElement;
            NewElement = newElement;
        }
    }
}
