using MTAServerWrapper;
using MTASharedWrapper;
using MTASharedWrapper.Enums;
using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace MTAServerResource
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            List<Vehicle> vehicles = new List<Vehicle>(); ;
            for (int i = 0; i < 10; i++)
            {
                Vehicle rhino = new Vehicle(VehicleModel.RHINO, new Vector3(i * 15, 0, 3));
                vehicles.Add(rhino);
            }
            vehicles[5].Rotation = new Vector3(0, 0, 45);

            MTAObject dildo = new MTAObject(321, new Vector3(3, 3, 3));
            dildo.Scale = new Vector3(3, 3, 3);
            dildo.Move(5000, new Vector3(3, 3, 10));

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

            Color color = new Color(0xff00aa55);
            Console.WriteLine("Color: " + color.R + ", " + color.G + ", " + color.B + ", " + color.A);
            // alpha.AddEventHandler("onVehicleDamage");
            alpha.OnDamage += (float loss) =>
            {
                Console.WriteLine("Vehicle lost " + loss +" health");

                //Player player = new Player(Server.GetRandomPlayer());
                //player.Camera.Fade(CameraFade.OUT, new Color(0xff00aa));
            };

            Player player = new Player(Server.GetRandomPlayer());

            MTAObject bin = new MTAObject(1337, player.Position + player.ForwardVector * 3 + player.UpVector * 2);
            bin.QuaternionRotation = player.QuaternionRotation;
           
            // Console.WriteLine(File.ReadAllText("meta.xml"));
        }
    }
}
