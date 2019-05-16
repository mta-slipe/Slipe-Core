using Slipe.MtaDefinitions;
using Slipe.Server.Game;
using Slipe.Server.Peds;
using Slipe.Server.Peds.Events;
using Slipe.Server.Vehicles;
using Slipe.Shared.Elements;
using Slipe.Shared.Peds;
using Slipe.Shared.Utilities;
using Slipe.Shared.Vehicles;
using System;
using System.Numerics;
using Slipe.Shared.Rendering;
using System.Timers;
using Slipe.Server.Vehicles.Events;

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
            // Spawn a player in Blueberry
            Player.OnJoin += (Player source, OnJoinArgs eventArgs) =>
            {
                source.Spawn(new Vector3(0, 0, 5), PedModel.ballas1);
            };
        }
    }

    [DefaultElementClass(ElementType.Player)]
    public class MyPlayer : Player
    {
        public MyPlayer(MtaElement element) : base(element)
        {
            OnSpawn += OnPlayerSpawn;
        }

        private void OnPlayerSpawn(Player source, OnSpawnArgs eventArgs)
        {
            Console.WriteLine(eventArgs.Model);
            Console.WriteLine(eventArgs.Interior);
            Camera.Target = this;
            Camera.Fade(CameraFade.In);
        }
    }

    [DefaultElementClass(ElementType.Vehicle)]
    public class MyVehicle : Vehicle
    {
        public MyVehicle(MtaElement element) : base(element)
        {
            PrimaryColor = Color.ForestGreen;
            OnEnter += (Vehicle source, OnEnterArgs eventArgs) =>
            {
                eventArgs.Player.Model = (int)PedModel.army;
            };
        }

        public MyVehicle(Vector3 pos) : base(VehicleModel.Cars.Alpha, pos)
        {
            PrimaryColor = Color.ForestGreen;
        }

    }

}
