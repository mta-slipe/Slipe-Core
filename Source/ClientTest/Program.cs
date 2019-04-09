using Slipe.Client.Enums;
using RPCDefinitions;
using System;
using System.Diagnostics;
using System.Numerics;
using Slipe.Shared.Rpc;
using Slipe.Client.Dx;
using Slipe.Client.Assets;
using Slipe.Client.Effects;
using Slipe.Client.Sounds;
using Slipe.Shared.Elements;
using Slipe.Shared.Peds;
using Slipe.Client.Elements;
using Slipe.Client.GameClient;
using Slipe.Client.Browsers;
using Slipe.Client.IO;
using Slipe.Client.Gui;
using Slipe.Client.Rpc;
using Slipe.Client.Peds;

namespace ClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            new ElementManager(new ElementHelper());
            new Program();
        }

        private GuiBrowser guiBrowser;
        private Browser browser;

        public Program()
        {
            ChatBox.WriteLine("hey", 0xff00ff);
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
            RpcManager.Instance.RegisterRPC<BasicIncomingRpc>("testRPC", HandleTestRPC);
            RpcManager.Instance.TriggerRPC("onPlayerReady", new EmptyOutgoingRpc());

            Element dummy = new Element("flag", "ab3x");
            Debug.WriteLine(dummy.Type);

            Client.Engine.SetAsynchronousLoading(true);
            new Mod("Assets/m4.txd", "Assets/m4.dff").ApplyTo(356);

            new CustomAnimation("Assets/salute.ifp").ApplyTo("salute");

            new Sound(SoundContainer.spc_pa, 16, 9);
            WorldSound deutschland = new WorldSound("http://www.noiseaddicts.com/samples_1w72b820/4192.mp3", new Vector3(-62, 46, 4), true);
            Debug.WriteLine("Playing in the barn: " + deutschland.MetaTags.Title);
            Debug.WriteLine("Tempo: " + deutschland.Properties.Tempo);
            deutschland.Effects.Distorion = true;
            new WorldSound(RadioStation.KDST, 1, new Vector3(0, 0, 4), true);

            Player.Local.SetAnimation(new Animation("salute", "mil_salutePrt"), false);

            Vector3 pos = Player.Local.Position;
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                Vector3 newPos = new Vector3(pos.X + r.Next(-5, 5), pos.Y + r.Next(-5, 5), pos.Z + r.Next(-5, 5));
                Fx.WaterHydrant(newPos);
            }

            Effect ef = new Effect(EffectType.fire_large, pos, Vector3.Zero);

            Debug.WriteLine(Client.Renderer.Status.VideoCardName);
            Debug.WriteLine(Client.Renderer.Status.VideoCardRAM);

            string[] names = Client.Engine.GetModelTextureNames(321);
            Debug.WriteLine("Texture count: {0}", names.Length);
            foreach (string texture in names)
            {
                Debug.WriteLine(texture);
            }
        }

        public void HandleTestRPC(BasicIncomingRpc arguments)
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
