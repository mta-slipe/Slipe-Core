using SlipeLua.Shared.Explosions;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SlipeLua.Client.Elements.Events
{
    public class OnExplosionEventArgs
    {
        /// <summary>
        /// The position of the explosion
        /// </summary>
        public Vector3 Position { get; }

        /// <summary>
        /// The type of the explosion
        /// </summary>
        public ExplosionType Type { get; }

        internal OnExplosionEventArgs(dynamic x, dynamic y, dynamic z, dynamic type)
        {
            Position = new Vector3((float)x, (float)y, (float)z);
            Type = (ExplosionType)type;
        }
    }
}
