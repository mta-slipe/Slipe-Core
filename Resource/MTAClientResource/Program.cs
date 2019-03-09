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

            //GUIBrowser guiBrowser = new GUIBrowser(0, 0, 1, 1, false, true, true);
            //Browser browser = guiBrowser.Browser;
            //browser.AddEventHandler("onClientBrowserCreated");
            //browser.OnCreated += () =>
            //{
            //    Browser.OnDomainRequestAccepted += (string domain) =>
            //    {
            //        browser.LoadUrl("https://nanobob.net");
            //        Cursor.SetVisible(true);

            //        browser.AddEventHandler("onClientBrowserDocumentReady");
            //        browser.OnDocumentReady += (string url) =>
            //        {
            //            browser.ExecuteJavascript("testMethod", new JavascriptVariable[]
            //            {
            //                new JavascriptVariable("test"),
            //                new JavascriptVariable(true),
            //                new JavascriptVariable(new string[]{
            //                    "hey", "there"
            //                }),
            //                new JavascriptVariable(5.2),
            //                new JavascriptVariable(10),
            //            });
            //        };
            //    };
            //    Browser.RequestDomain("nanobob.net", false);
            };
        }
    }
}
