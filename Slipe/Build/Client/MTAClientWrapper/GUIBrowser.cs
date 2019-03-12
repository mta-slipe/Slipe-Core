using MTASharedWrapper;
using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace MTAClientWrapper
{
    public class GUIBrowser: GUIElement
    {
        Browser browser;
        public Browser Browser { get { return browser; } }

        public GUIBrowser(MTAElement element): base(element)
        {

        }

        public GUIBrowser(Vector2 position, float width, float height, bool isLocal, bool isTransparent, bool isRelative): base()
        {

            this.element = Client.GuiCreateBrowser(position.X, position.Y, width, height, isLocal, isTransparent, isRelative, null);
            ElementManager.Instance.RegisterElement(this);


            this.browser = new Browser(Client.GuiGetBrowser(this.element));
        }
    }
}
