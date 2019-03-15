using Slipe.Shared;
using Slipe.Shared.Enums;
using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Slipe.Server
{
    public class Explosion
    {
        public static bool Create(Vector3 position, ExplosionType type, Element creator = null)
        {
            return MTAServer.CreateExplosion(position.X, position.Y, position.Z, (int) type, creator != null ? creator.MTAElement : null);
        }

        private Explosion()
        {

        }
    }
}
