using Slipe.Shared;
using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Slipe.Client
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

            this.element = MTAClient.GuiCreateBrowser(position.X, position.Y, width, height, isLocal, isTransparent, isRelative, null);
            ElementManager.Instance.RegisterElement(this);


            this.browser = new Browser(MTAClient.GuiGetBrowser(this.element));
        }
    }
}
