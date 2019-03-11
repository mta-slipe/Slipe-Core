using MTASharedWrapper;
using MTASharedWrapper.Enums;
using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MTAClientWrapper
{
    public class Explosion
    {
        public static bool Create(Vector3 position, ExplosionType type, bool makeSound = true, float camShake = -1)
        {
            return Client.CreateExplosion(position.X, position.Y, position.Z, (int) type, makeSound, camShake);
        }

        private Explosion()
        {

        }
    }
}
