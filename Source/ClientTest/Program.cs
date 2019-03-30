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
using Slipe.Client.Dx;

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
            RPCManager.Instance.RegisterRPC<BasicIncomingRPC>("testRPC", HandleTestRPC);
            RPCManager.Instance.TriggerRPC("onPlayerReady", new EmptyOutgoingRPC());

            Light l = new Light(LightTypeEnum.SPOT, Player.Local.Position, 4, Color.White, Player.Local.ForwardVector, true);
            SearchLight s = new SearchLight(new Vector3(0, 0, 5), new Vector3(0, 0, 0), 0, 10);
            s.AttachTo(Player.Local);

            Vector2 start = new Vector2(100, 100);
            Vector2 end = new Vector2(500, 500);

            DxLine line = new DxLine(start, end, Color.Red);
            DxCircle circle = new DxCircle(end, 100, Color.Red);
            DxText text = new DxText("Bob is a scuffed Programmer", end);
            text.AttachTo(Player.Local);

            Vector3 lineStart = Player.Local.Position;
            Vector3 lineEnd = lineStart + new Vector3(2, 2, 2);
            Dx3DLine dine = new Dx3DLine(lineStart, lineEnd);
            dine.AttachTo(Player.Local);

            Client.Renderer.OnRender += () =>
            {
                line.Draw();
                circle.Draw();
                text.Draw();
                dine.Draw();
            };

            
        }

        public void HandleTestRPC(BasicIncomingRPC arguments)
        {
            Debug.WriteLine("Handling testRPC, name: {0}, x: {1}, player name: {2}", arguments.name, arguments.x, ((Player)arguments.element).Name);
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
