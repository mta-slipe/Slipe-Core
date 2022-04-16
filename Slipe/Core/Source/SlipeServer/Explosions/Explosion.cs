using SlipeLua.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Explosions;

namespace SlipeLua.Server.Explosions
{
    /// <summary>
    /// An explosion in the world
    /// </summary>
    public class Explosion
    {
        /// <summary>
        /// Creates an explosion at a certain position of a certain type
        /// </summary>
        public static bool Create(Vector3 position, ExplosionType type, Element creator = null)
        {
            return MtaServer.CreateExplosion(position.X, position.Y, position.Z, (int)type, creator?.MTAElement);
        }

        private Explosion()
        {

        }
    }
}
