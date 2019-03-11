using MTASharedWrapper;
using MTASharedWrapper.Enums;
using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MTAServerWrapper
{
    public class Explosion
    {
        public static bool Create(Vector3 position, ExplosionType type, Element creator = null)
        {
            return Server.CreateExplosion(position.X, position.Y, position.Z, (int) type, creator != null ? creator.MTAElement : null);
        }

        private Explosion()
        {

        }
    }
}
