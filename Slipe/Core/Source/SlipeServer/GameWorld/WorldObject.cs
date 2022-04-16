using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using SlipeLua.MtaDefinitions;
using System.ComponentModel;
using SlipeLua.Shared.GameWorld;
using SlipeLua.Shared.Elements;

namespace SlipeLua.Server.GameWorld
{
    /// <summary>
    /// Class representing an Object in MTA
    /// </summary>
    [DefaultElementClass(ElementType.Object)]
    public class WorldObject : SharedWorldObject
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
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
