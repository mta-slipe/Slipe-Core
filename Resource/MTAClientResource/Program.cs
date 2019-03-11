using MTAClientWrapper;
using MTAClientWrapper.Javascript;
using System;

namespace MTAClientResource
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Client!");
            new Program();
        }

        private GUIBrowser guiBrowser;
        private Browser browser;

        public Program()
        {
            guiBrowser = new GUIBrowser(0, 0, 1, 1, false, true, true);
            browser = guiBrowser.Browser;

            Browser.OnDomainRequestAccepted += OnDomainRequestAccepted;
            browser.OnCreated += OnCreated;
            browser.OnDocumentReady += OnReady;

            browser.AddEventHandler("onClientBrowserCreated");
        }

        public void OnCreated()
        {
            Browser.RequestDomain("nanobob.net", false);
        }

        public void OnDomainRequestAccepted(string domain)
        {
            browser.LoadUrl("https://nanobob.net");
            Cursor.SetVisible(true);

            browser.AddEventHandler("onClientBrowserDocumentReady");
        }

        public void OnReady(string url)
        {
            browser.ExecuteJavascript("testMethod", new JavascriptVariable[]
            {
                new JavascriptVariable("test"),
                new JavascriptVariable(true),
                new JavascriptVariable(new string[]{
                    "hey", "there"
                }),
                new JavascriptVariable(5.2),
                new JavascriptVariable(10),
            });
        }
    }
}
