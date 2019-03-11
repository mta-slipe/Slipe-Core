using MTASharedWrapper;
using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTAClientWrapper
{
    public class GUIBrowser: GUIElement
    {
        Browser browser;
        public Browser Browser { get { return browser; } }

        public GUIBrowser(float x, float y, float width, float height, bool isLocal, bool isTransparent, bool isRelative)
        {
            this.element = Client.GuiCreateBrowser(x, y, width, height, isLocal, isTransparent, isRelative, null);
            ElementManager.Instance.RegisterElement(this);

            this.browser = new Browser(Client.GuiGetBrowser(this.element));
        }
    }
}
