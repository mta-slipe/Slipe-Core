using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTAClientWrapper
{
    class Browser: Element
    {
        public Browser(int width, int height, bool isLocal, bool transparent = false)
        {
            this.element = Client.CreateBrowser(width, height, isLocal, transparent);
        }

        public bool ReloadPage()
        {
            return Client.ReloadBrowserPage(element);
        }

        public bool LoadUrl(string url, string postData = null, bool urlEncoded = true)
        {
            return Client.LoadBrowserURL(element, url, postData, urlEncoded);
        }
    }
}
