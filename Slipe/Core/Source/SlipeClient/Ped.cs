using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;
using Slipe.Shared;
using Slipe.Shared.Enums;

namespace Slipe.Client
{
    /// <summary>
    /// Represents a pedestrian 
    /// </summary>
    public class Ped : SharedPed
    {
        public Ped() : base() { }

        /// <summary>
        /// Create a ped from an empty element
        /// </summary>
        public Ped(MTAElement element) : base(element) { }

        /// <summary>
        /// Create a new ped
        /// </summary>
        public Ped(PedModel model, Vector3 position, float rotation = 0.0f)
        {
            element = MTAClient.CreatePed((int)model, position.X, position.Y, position.Z, rotation);
        }
    }
}
