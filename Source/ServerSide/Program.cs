
using Slipe.Server.Elements;
using Slipe.Server.GameServer;
using Slipe.Server.Vehicles;
using Slipe.Shared.Elements;
using System.Numerics;
using Slipe.Shared.Utilities;
using Slipe.Server.Peds;
using Slipe.Server.Resources;
using System;

namespace ServerSide
{
    class Program
    {
        static void Main(string[] args)
        {
            new ElementManager(new ElementHelper());
            new Program();
        }

        public Program()
        {           
            Team awesome = new Team("Awesome", Color.HotPink);

            foreach(Player p in Player.Alive)
            {
                p.Team = awesome;
            }

            TeamVehicle t = new TeamVehicle(VehicleModel.Patriot, new Vector3(1954, -2166, 15), awesome);

            Gate[] gateArray = {
                new Gate(new Vector3(1964.27f, -2189.76f, 14.37f), new Vector3(0, 0, 106.7f), new Vector3(1969.52f, -2189.78f, 14.37f)),
                new Gate(new Vector3(1958.8f, -2189.76f, 14.37f), new Vector3(0, 0, 106.7f), new Vector3(1953.64f, -2189.77f, 14.37f))
            };
            GateGroup lsAirport = new GateGroup(new Vector3(1957, -2202, 12), new Vector3(1967, -2176, 17), gateArray);
        }
    }
}
