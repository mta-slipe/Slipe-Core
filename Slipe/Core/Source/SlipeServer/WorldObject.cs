using Slipe.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;

namespace Slipe.Server
{
    /// <summary>
    /// Class representing an Object in MTA
    /// </summary>
    public class WorldObject : SharedWorldObject
    {

        /// <summary>
        /// Creates a World object from an MTA object element
        /// </summary>
        public WorldObject(MTAElement element): base(element)
        {

        }

        /// <summary>
        /// Creates a world object at a certain position
        /// </summary>
        public WorldObject(int model, Vector3 position) : base(model, position)
        {
        }

        /// <summary>
        /// Creats a world object using all of the createObject parameters
        /// </summary>
        public WorldObject(int model, Vector3 position, Vector3 rotation, bool isLowLOD = false) : base(model, position, rotation, isLowLOD)
        {
        }
    }
}
