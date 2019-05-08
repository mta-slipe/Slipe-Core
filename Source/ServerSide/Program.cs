using Slipe.MtaDefinitions;
using Slipe.Server.Game;
using Slipe.Server.Peds;
using Slipe.Server.Vehicles;
using Slipe.Shared.Elements;
using Slipe.Shared.Peds;
using Slipe.Shared.Utilities;
using Slipe.Shared.Vehicles;
using System;
using System.Numerics;

namespace ServerSide
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {

        }
    }

    [DefaultElementClass("player")]
    public class MyPlayer : Player
    {
        public MyPlayer(MtaElement element) : base(element)
        {
            Console.WriteLine("We instantiated a MyPlayer as a default player yay! :D");
            Health -= 20;
        }
    }

    [DefaultElementClass("vehicle")]
    public class MyVehicle : Vehicle
    {
        public MyVehicle(MtaElement element) : base(element)
        {
            PrimaryColor = Color.ForestGreen;
            OnEnter += (Player player, Seat seat, Player jacked) =>
            {
                player.Model = (int)PedModel.army;
            };
        }

        public MyVehicle(Vector3 pos, bool test, Vector2 bla) : base(VehicleModel.Alpha, pos)
        {
            PrimaryColor = Color.ForestGreen;
        }

    }

}
