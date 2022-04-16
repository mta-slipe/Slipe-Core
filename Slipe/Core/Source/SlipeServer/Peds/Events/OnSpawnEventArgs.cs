using SlipeLua.MtaDefinitions;
using SlipeLua.Server.Game;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Peds;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SlipeLua.Server.Peds.Events
{
    public class OnSpawnEventArgs
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


        internal OnSpawnEventArgs(dynamic x, dynamic y, dynamic z, dynamic rotation, MtaElement team, dynamic model, dynamic interior, dynamic dimension)
        {
            Position = new Vector3((float)x, (float)y, (float)z);
            Rotation = (float) rotation;
            Team = ElementManager.Instance.GetElement<Team>(team);
            Model = (PedModel) model;
            Interior = (int) interior;
            Dimension = (int) dimension;
        }
    }
}
