using SlipeLua.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using SlipeLua.Shared.Elements;
using SlipeLua.Client.Browsers;
using System.ComponentModel;

namespace SlipeLua.Client.Gui
{
    /// <summary>
    /// GUI variant of a browser element
    /// </summary>
    [DefaultElementClass(ElementType.GuiBrowser)]
    public class GuiBrowser : GuiElement
    {
        private Browser browser;

        /// <summary>
        /// Get the browser element associated with this GUI
        /// </summary>
        public Browser Browser { get { return browser; } }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public GuiBrowser(MtaElement element) : base(element)
        {

        }

        /// <summary>
        /// Create a new GUI browser
        /// </summary>
        public GuiBrowser(Vector2 position, float width, float height, bool isLocal, bool isTransparent, bool relative = false, GuiElement parent = null)
            : this(MtaClient.GuiCreateBrowser(position.X, position.Y, width, height, isLocal, isTransparent, relative, parent?.MTAElement))
        {
            browser = new Browser(MtaClient.GuiGetBrowser(element));
        }
    }
}
