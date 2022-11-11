using SlipeLua.Client.Dx;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SlipeLua.Client.Browsers
{
    public class BrowserMaterial : Material
    {
        public BrowserMaterial(Browser browser)
        {
            materialElement = browser.MTAElement;
        }
    }
}
