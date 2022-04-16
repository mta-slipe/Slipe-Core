using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Gui.Events
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
