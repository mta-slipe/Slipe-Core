using System;
using MultiTheftAuto;
using MTAWrapper;
using System.Collections.Generic;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Program();
        }

        public Program()
        {
            List<Vehicle> vehicles = new List<Vehicle>(); ;
            for (int i = 0; i < 10; i ++)
            {
                vehicles.Add(new Vehicle(VehicleModel.RHINO, new Vector3(i * 15, 0, 3)));
            }
            vehicles[5].SetRotation(new Vector3(0, 0, 45));


            Dictionary<string, Vehicle> vehicleDictionary= new Dictionary<string, Vehicle>();
            vehicleDictionary["best"] = vehicles[3];
            vehicleDictionary["best"].SetPosition(new Vector3(0, 0, 20));


            MultiTheftAuto.Element nanobob = Server.GetPlayerFromName("SAES>NanoBob");
            Server.GiveWeapon(nanobob, 31, 500, true);
            Server.AddEventHandler("onPlayerWeaponFire", nanobob, "src.Program.HandleWeaponFire" , true, "normal");

            try
            {
                throw new Exception("OI!");
            } catch (Exception)
            {
                Console.WriteLine("WAFFWAAWF");
            }
        }

        public static void HandleWeaponFire(int weapon, float endX, float endY, float endZ, MTAWrapper.Element hitElement, float startX, float startY, float startZ)
        {
            Console.WriteLine(weapon);
        }
    }
}
