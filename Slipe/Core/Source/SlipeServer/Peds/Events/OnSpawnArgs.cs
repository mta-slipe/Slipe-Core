using Slipe.Server.Game;
using Slipe.Shared.Peds;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnSpawnArgs
    {
        /// <summary>
        /// The spawn position
        /// </summary>
        public Vector3 Position { get; }

        /// <summary>
        /// The spawn rotation along the z-axis
        /// </summary>
        public float Rotation { get; }

        /// <summary>
        /// The team in which this player spawned
        /// </summary>
        public Team Team { get; }

        /// <summary>
        /// The model of the player ped
        /// </summary>
        public PedModel Model { get; }

        /// <summary>
        /// The interior
        /// </summary>
        public int Interior { get; }

        /// <summary>
        /// The dimension
        /// </summary>
        public int Dimension { get; }


        internal OnSpawnArgs(Vector3 position, float rotation, Team team, PedModel model, int interior, int dimension)
        {
            Position = position;
            Rotation = rotation;
            Team = team;
            Model = model;
            Interior = interior;
            Dimension = dimension;
        }
    }
}
