using Slipe.Shared.CollisionShapes;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Slipe.Server.Peds;

namespace ServerSide
{
    public class GateGroup : CollisionCuboid, IGateable
    {
        private IGateable[] gates;

        /// <summary>
        /// Create a gate group
        /// </summary>
        /// <param name="southWest">The south western vector of the collision cuboid</param>
        /// <param name="northEast">The north eastern vector of the collision cuboid</param>
        /// <param name="gates">An array of all subscribed gates</param>
        public GateGroup(Vector3 southWest, Vector3 northEast, IGateable[] gates) 
            : base(southWest, new Vector3(northEast.X - southWest.X, northEast.Y - southWest.Y, northEast.Z - southWest.Z))
        {
            this.gates = gates;
            OnHit += (PhysicalElement element, bool matchingDimension) =>
            {
                if (matchingDimension)
                    Open();
            };

            OnLeave += (PhysicalElement element, bool matchingDimension) => 
            {
                int playersWithin = GetElementsWithinOfType(typeof(Player)).Length;
                if (matchingDimension && playersWithin <= 0)
                    Close();
            };
        }

        /// <summary>
        /// Open the gates!
        /// </summary>
        public void Open()
        {
            foreach (IGateable gate in gates)
            {
                gate.Open();
            }
        }

        /// <summary>
        /// Close the gates!
        /// </summary>
        public void Close()
        {
            foreach (IGateable gate in gates)
            {
                gate.Close();
            }
        }
    }
}
