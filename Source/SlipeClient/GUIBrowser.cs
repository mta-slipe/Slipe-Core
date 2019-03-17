using Slipe.Shared;
using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Slipe.Client
{
    /// <summary>
    /// GUI variant of a browser element
    /// </summary>
    public class GUIBrowser: GUIElement
    {
        private Browser browser;

        /// <summary>
        /// Get the browser element associated with this GUI
        /// </summary>
        public Browser Browser { get { return browser; } }


        /// <summary>
        /// Create the GUI browser from a MTA GUI browser element
        /// </summary>
        public GUIBrowser(MTAElement element): base(element)
        {

        }

        /// <summary>
        /// Create a new GUI browser
        /// </summary>
        public GUIBrowser(Vector2 position, float width, float height, bool isLocal, bool isTransparent, bool isRelative): base()
        {

            this.element = MTAClient.GuiCreateBrowser(position.X, position.Y, width, height, isLocal, isTransparent, isRelative, null);
            ElementManager.Instance.RegisterElement(this);


            this.browser = new Browser(MTAClient.GuiGetBrowser(this.element));
        }
    }
}
