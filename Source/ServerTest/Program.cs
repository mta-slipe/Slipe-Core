using Slipe.Server;
using Slipe.Shared;
using Slipe.Shared.Enums;
using Slipe.Shared.Exceptions;
using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using RPCDefinitions;
using System.Timers;

namespace ServerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            new ElementManager(new ElementHelper());
            Timer aTimer = new Timer(2000);
            Console.WriteLine(aTimer.AutoReset.ToString());
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Enabled = true;
            aTimer.Interval = 4000;
            new Program();
        }

        public static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The elapsed event was raised at " + e.SignalTime.ToString());
            Timer t = (Timer)source;
            t.Enabled = false;
        }

        public Program()
        {
            List<Vehicle> vehicles = new List<Vehicle>(); ;
            for (int i = 0; i < 10; i++)
            {
                Vehicle rhino = new Vehicle(VehicleModel.RHINO, new Vector3(i * 15, 0, 3));
                Blip blip = new Blip(rhino);
                vehicles.Add(rhino);
            }
            vehicles[5].Rotation = new Vector3(0, 0, 45);

            WorldObject dildo = new WorldObject(321, new Vector3(3, 3, 3));
            dildo.Scale = new Vector3(3, 3, 3);
            dildo.Move(5000, new Vector3(3, 3, 10), Vector3.Zero, EasingFunctionEnum.COSINECURVE, 0.4f, 0.5f);
            Console.WriteLine("{0} is a pleb", "SAES>Dezzolation");

            vehicles[4].AttachTo(dildo, new Vector3(0, 0, 3));

            Dictionary<string, Vehicle> vehicleDictionary = new Dictionary<string, Vehicle>();
            vehicleDictionary["best"] = vehicles[3];
            vehicleDictionary["best"].Position = new Vector3(0, 0, 20);
            vehicleDictionary["best"].Frozen = true;

            foreach (Vehicle vehicle in ElementHelper.GetByType<Vehicle>())
            {
                vehicle.Rotation = new Vector3(0, 0, 90);
            }


            Vehicle alpha = new Vehicle(VehicleModel.ALPHA, new Vector3(0, 10, 3));

            Element.Root.AddEventHandler("onVehicleDamage");

            Color color = new Color(0x0000ff);
            color = new Color(0xff00ffaa);
            color = new Color((uint) 0x000000ff);
            Debug.WriteLine("Color: {0}, {1}, {2}, {3}", color.R, color.G, color.B, color.A);
            // alpha.AddEventHandler("onVehicleDamage");
            alpha.OnDamage += (float loss) =>
            {
                Console.WriteLine("Vehicle lost " + loss +" health");

                try
                {
                    Player nano = (Player)Player.GetFromName("SAES>Nanobob");
                }
                catch (NullElementException) { }
                //nano.Camera.Fade(CameraFade.OUT, new Color(0xff00aa));

                RPCManager.Instance.TriggerRPC("testRPC", new TestRPC("Test rpc", 10));
            };

            foreach(Account account in Account.All)
            {
                account.SetData("Test", "Success");
                foreach(KeyValuePair<string, string> pair in account.AllData)
                {
                    Debug.WriteLine(pair.Key);
                    Debug.WriteLine(pair.Value);
                }
            }

            Console.WriteLine(Resource.This.LoadTime.ToString());

            // Console.WriteLine(File.ReadAllText("meta.xml"));
        }
    }
}
