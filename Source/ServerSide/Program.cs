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
using Slipe.Shared.Rendering;
using System.Timers;

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
            Player.OnJoin += (Player p) =>
            {
                p.Spawn(new Vector3(0, 0, 5));
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

        private void OnPlayerSpawn(Vector3 position, float rotation, Team team, PedModel model, int interior, int dimension)
        {
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
