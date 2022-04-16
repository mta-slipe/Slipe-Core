using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SlipeLua.Client.Gui.Events
{
    public class OnMouseLeaveEventArgs
    {
        /// <summary>
        /// The 2D position of the mouse
        /// </summary>
        public Vector2 Position { get; }

        /// <summary>
        /// The new gui element the mouse is on
        /// </summary>
        public GuiElement Element { get; }

        internal OnMouseLeaveEventArgs(dynamic x, dynamic y, MtaElement element)
        {
            Position = new Vector2((float)x, (float)y);
            Element = ElementManager.Instance.GetElement<GuiElement>(element);
        }
    }
}
