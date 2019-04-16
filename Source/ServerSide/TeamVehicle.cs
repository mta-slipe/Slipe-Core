using Slipe.Server.Events;
using Slipe.Server.GameServer;
using Slipe.Server.Peds;
using Slipe.Server.Vehicles;
using Slipe.Shared.Vehicles;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ServerSide
{
    public class TeamVehicle : Vehicle
    {
        public Team Team { get; }

        public TeamVehicle(VehicleModel model, Vector3 position, Team team) : base(model, position)
        {
            Team = team;

            OnStartEnter += (Player player, Seat seat, Player jacked, Door door) =>
            {
                if (seat == Seat.FrontLeft && player.Team != team)
                    Event.Cancel();
            };
        }
    }
}
