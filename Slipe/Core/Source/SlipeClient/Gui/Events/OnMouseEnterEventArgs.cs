using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Slipe.Client.Gui.Events
{
    public class OnMouseEnterEventArgs
    {
        /// <summary>
        /// The 2D position of the mouse
        /// </summary>
        public Vector2 Position { get; }

        /// <summary>
        /// The previous gui element the mouse was on
        /// </summary>
        public GuiElement Element { get; }

        internal OnMouseEnterEventArgs(dynamic x, dynamic y, MtaElement element)
        {
            Position = new Vector2((float)x, (float)y);
            Element = ElementManager.Instance.GetElement<GuiElement>(element);
        }
    }
}
