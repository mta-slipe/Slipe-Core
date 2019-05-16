using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Gui.Events
{
    public class OnAcceptedEventArgs
    {
        /// <summary>
        /// The element which had focus
        /// </summary>
        public GuiElement Element { get; }

        internal OnAcceptedEventArgs(MtaElement element)
        {
            Element = ElementManager.Instance.GetElement<GuiElement>(element);
        }
    }
}
