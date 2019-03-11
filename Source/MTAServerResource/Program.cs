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
            Quaternion q = new Quaternion(12, 41, 42, 10);
            Quaternion p = new Quaternion(new Vector3(10, 20, 4), 6);
            Console.WriteLine(q.GetHashCode());
            Console.WriteLine((q * p).ToString());
            Complex c = Complex.Zero;
            Console.WriteLine(c.Imaginary);
            Vector4 v3 = new Vector4(5);
            Vector4 v4 = new Vector4(3);
            Vector4 result = v3 * 2;
            Vector4 result2 = 4 * v4;
            Vector3 v1 = new Vector3(4, 5, 6);
            Plane p1 = new Plane(v4);
            Plane p2 = new Plane(v1, 39);
            Console.WriteLine(p2.ToString());
            Console.WriteLine(result2.X);
            Console.WriteLine(v3.Length());
            string asdf = "asdf";
            Console.WriteLine(asdf[2]); // will print d ?
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

            // Console.WriteLine(File.ReadAllText("meta.xml"));
        }
    }
}
