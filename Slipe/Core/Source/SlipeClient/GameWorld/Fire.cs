using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Slipe.Client.GameWorld
{
    public static class Fire
    {
        public static bool Create(Vector3 position, float size)
        {
            return MtaClient.CreateFire(position.X, position.Y, position.Z, size);
        }

        public static bool Extinguish(Vector3 position, float radius)
        {
            return MtaClient.ExtinguishFire(position.X, position.Y, position.Z, radius);
        }
    }
}
