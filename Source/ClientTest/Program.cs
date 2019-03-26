using Slipe.Client;
using Slipe.Client.Javascript;
using Slipe.Client.Enums;
using Slipe.Shared;
using RPCDefinitions;
using System;
using System.Diagnostics;
using System.Numerics;
using Slipe.Shared.Enums;
using Slipe.Shared.Structs;
using Slipe.Shared.RPC;

namespace ClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            new ElementManager(new ElementHelper());
            new Program();
        }

        private GUIBrowser guiBrowser;
        private Browser browser;

        public Program()
        {
            //guiBrowser = new GUIBrowser(Vector2.Zero, 1, 1, false, true, true);
            //browser = guiBrowser.Browser;

            //Browser.OnDomainRequestAccepted += OnDomainRequestAccepted;
            //browser.OnCreated += OnCreated;
            //browser.OnDocumentReady += OnReady;

            //browser.AddEventHandler("onClientBrowserCreated");
            //Camera.Instance.SetGoggleEffect(Slipe.Client.Enums.GoggleEffects.NORMAL);

            //RPCManager.Instance.RegisterRPC("testRPC", (TestRPCStruct arguments) => {
            //    Debug.WriteLine("Handling testRPC, name: {0}, x: {1}", arguments.name, arguments.x);
            //});
            RPCManager.Instance.RegisterRPC<TestRPC>("testRPC", HandleTestRPC);
            RPCManager.Instance.TriggerRPC("onPlayerReady", new EmptyOutgoingRPC());

            Light l = new Light(LightTypeEnum.SPOT, Player.Local.Position, 4, Color.White, Player.Local.ForwardVector, true);
            SearchLight s = new SearchLight(Player.Local.Position + new Vector3(0, 0, 5), Player.Local.Position - new Vector3(0, 0, 1), 0, 10);

            Vector2 start = new Vector2(100, 100);
            Vector2 end = new Vector2(500, 500);
            Vector2 end2 = new Vector2(100, 500);
            Client.Renderer.OnRender += () =>
            {
                Client.Renderer.DrawLine(start, end, Color.Red);
            };

            Client.Renderer.OnRender += () =>
            {
                Client.Renderer.DrawLine(start, end2, Color.Red);
            };
        }

        public void HandleTestRPC(TestRPC arguments)
        {
            Debug.WriteLine("Handling testRPC, name: {0}, x: {1}", arguments.name, arguments.x);
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
