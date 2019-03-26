using Slipe.Shared;
using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client
{
    public abstract class GUIElement: Element
    {
        /// <summary>
        /// Get and set if this GUI element is visible
        /// </summary>
        public bool Visible
        {
            get
            {
                return MTAClient.GuiGetVisible(element);
            }
            set
            {
                MTAClient.GuiSetVisible(element, value);
            }
        }

        /// <summary>
        /// Get and set the alpha of this GUI element
        /// </summary>
        public float Alpha
        {
            get
            {
                return MTAClient.GuiGetAlpha(element);
            }
            set
            {
                MTAClient.GuiSetAlpha(element, value);
            }
        }

        public GUIElement()
        {

        }

        /// <summary>
        /// Create a GUI elemenet from an MTA GUI element
        /// </summary>
        public GUIElement(MTAElement element): base(element)
        {

        }
    }
}
