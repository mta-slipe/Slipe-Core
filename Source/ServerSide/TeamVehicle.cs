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
    /// <summary>
    /// A vehicle that is locked to a team
    /// </summary>
    public class TeamVehicle : Vehicle
    {
        /// <summary>
        /// The team that this vehicle is locked to
        /// </summary>
        public Team Team { get; }

        /// <summary>
        /// Create a new vehicle locked to a team
        /// </summary>
        /// <param name="model">The vehicle model</param>
        /// <param name="position">The position of this vehicle on the map</param>
        /// <param name="team">The team to which it's locked to</param>
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
