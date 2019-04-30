using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MtaDefinitions;
using System.ComponentModel;
using Slipe.Shared.GameWorld;
using Slipe.Shared.Elements;

namespace Slipe.Server.GameWorld
{
    /// <summary>
    /// Class representing an Object in MTA
    /// </summary>
    [DefaultElementClass("object")]
    public class WorldObject : SharedWorldObject
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DefaultElementConstructor]
        public WorldObject(MtaElement element) : base(element)
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
