using MTAServerWrapper;
using MTASharedWrapper;
using System;
using System.Collections.Generic;

namespace MTAServerResource
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
            for (int i = 0; i < 10; i++)
            {
                vehicles.Add(new Vehicle(VehicleModel.RHINO, new Vector3(i * 15, 0, 3)));
            }
            vehicles[5].Rotation = new Vector3(0, 0, 45);


            Dictionary<string, Vehicle> vehicleDictionary = new Dictionary<string, Vehicle>();
            vehicleDictionary["best"] = vehicles[3];
            vehicleDictionary["best"].Position = new Vector3(0, 0, 20);
        }
    }
}
