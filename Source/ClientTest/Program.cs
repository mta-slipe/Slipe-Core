using Slipe.Client;
using Slipe.Client.Javascript;
using Slipe.Shared;
using RPCDefinitions;
using System;
using System.Diagnostics;
using System.Numerics;
using Slipe.Shared.Enums;
using Slipe.Shared.Structs;

namespace ClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            new ElementManager(new ElementHelper());

            new SWATRope(Player.Local.Position + new Vector3(0, 0, 5), 5000);
            World.Instance.Weather = new Weather(WeatherEnum.SUNNYCOUNTRYSIDE);
            World.Instance.GetGarage(GarageEnum.PROPERTYPALOMINOCREEK).Open = true;

            Pickup pickup = new Pickup(new Vector3(4, 24, 3), PickupTypeEnum.ARMOUR, 50);
            Debug.WriteLine(pickup.Ammo.ToString());
            Debug.WriteLine(pickup.PickupType.ToString());
            Debug.WriteLine(pickup.Weapon.ToString());
            Debug.WriteLine(pickup.Amount.ToString());
            pickup.Morph(1337);
            Debug.WriteLine("Hello Client!");
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
            /// RPCManager.Instance.RegisterRPC<TestRPC>("testRPC", HandleTestRPC);
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
