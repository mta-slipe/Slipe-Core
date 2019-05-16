using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Gui.Events
{
    public class OnChangedEventArgs
    {
        /// <summary>
        /// The Gui element which was changed
        /// </summary>
        public EditableGuiElement Element { get; }

        internal OnChangedEventArgs(MtaElement element)
        {
            Element = ElementManager.Instance.GetElement<EditableGuiElement>(element);
        }
    }
}
