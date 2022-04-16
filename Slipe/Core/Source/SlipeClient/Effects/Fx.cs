using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Utilities;

namespace SlipeLua.Client.Effects
{
    /// <summary>
    /// Class that enables creation of short lived effects in the world
    /// </summary>
    public static class Fx
    {
        /// <summary>
        /// Creates a blood splatter particle effect.
        /// </summary>
        public static bool Blood(Vector3 position, Vector3 direction, int count = 1, float brightness = 1.0f)
        {
            return MtaClient.FxAddBlood(position.X, position.Y, position.Z, direction.X, direction.Y, direction.Z, count, brightness);
        }

        /// <summary>
        /// Creates a bullet impact particle effect, consisting of a small smoke cloud and a number of sparks.
        /// </summary>
        public static bool BulletImpact(Vector3 position, Vector3 direction, int smokeSize = 1, int sparkCount = 1, float smokeIntensity = 1.0f)
        {
            return MtaClient.FxAddBulletImpact(position.X, position.Y, position.Z, direction.X, direction.Y, direction.Z, smokeSize, sparkCount, smokeIntensity);
        }

        /// <summary>
        /// This function creates a bullet splash particle effect, normally created when shooting into water.
        /// </summary>
        public static bool BulletSplash(Vector3 position)
        {
            return MtaClient.FxAddBulletSplash(position.X, position.Y, position.Z);
        }

        /// <summary>
        /// Creates a debris particle effect (e.g. bits that fly off a car when ramming a wall).
        /// </summary>
        public static bool Debris(Vector3 position, Color color, float scale = 1.0f, int count = 1)
        {
            return MtaClient.FxAddDebris(position.X, position.Y, position.Z, color.R, color.G, color.B, color.A, scale, count);
        }

        /// <summary>
        /// This function creates a foot splash particle effect, normally created when walking into water.
        /// </summary>
        public static bool FootSplash(Vector3 position)
        {
            return MtaClient.FxAddFootSplash(position.X, position.Y, position.Z);
        }

        /// <summary>
        /// This function creates a glass particle effect.
        /// </summary>
        public static bool Glass(Vector3 position, Color color, float scale = 1.0f, int count = 1)
        {
            return MtaClient.FxAddGlass(position.X, position.Y, position.Z, color.R, color.G, color.B, color.A, scale, count);
        }

        /// <summary>
        /// This function creates a gunshot particle effect.
        /// </summary>
        public static bool Gunshot(Vector3 position, Vector3 direction, bool includeSparks = true)
        {
            return MtaClient.FxAddGunshot(position.X, position.Y, position.Z, direction.X, direction.Y, direction.Z, includeSparks);
        }

        /// <summary>
        /// Creates a punch impact particle effect (a small dust cloud).
        /// </summary>
        public static bool PunchImpact(Vector3 position, Vector3 direction)
        {
            return MtaClient.FxAddPunchImpact(position.X, position.Y, position.Z, direction.X, direction.Y, direction.Z);
        }

        /// <summary>
        /// Creates a number of sparks originating from a point
        /// </summary>
        public static bool Sparks(Vector3 position, Vector3 direction, float force = 1, int count = 1, bool blur = false, float spread = 1, float life = 1)
        {
            return MtaClient.FxAddSparks(position.X, position.Y, position.Z, direction.X, direction.Y, direction.Z, force, count, 0, 0, 0, blur, spread, life);
        }

        /// <summary>
        /// Creates a number of sparks on a line
        /// </summary>
        public static bool Sparks(Vector3 lineStart, Vector3 lineEnd, Vector3 direction, float force = 1, int count = 1, bool blur = false, float spread = 1, float life = 1)
        {
            return MtaClient.FxAddSparks(lineStart.X, lineStart.Y, lineStart.Z, direction.X, direction.Y, direction.Z, force, count, lineEnd.X, lineEnd.Y, lineEnd.Z, blur, spread, life);
        }

        /// <summary>
        /// This function creates a tank firing particle effect.
        /// </summary>
        public static bool TankFire(Vector3 position, Vector3 direction)
        {
            return MtaClient.FxAddTankFire(position.X, position.Y, position.Z, direction.X, direction.Y, direction.Z);
        }

        /// <summary>
        /// Creates a tyre burst particle effect (a small white smoke puff).
        /// </summary>
        public static bool TyreBurst(Vector3 position, Vector3 direction)
        {
            return MtaClient.FxAddTyreBurst(position.X, position.Y, position.Z, direction.X, direction.Y, direction.Z);
        }

        /// <summary>
        /// This function creates a water hydrant particle effect.
        /// </summary>
        public static bool WaterHydrant(Vector3 position)
        {
            return MtaClient.FxAddWaterHydrant(position.X, position.Y, position.Z);
        }

        /// <summary>
        /// This function creates a water splash particle effect.
        /// </summary>
        public static bool WaterSplash(Vector3 position)
        {
            return MtaClient.FxAddWaterSplash(position.X, position.Y, position.Z);
        }

        /// <summary>
        /// Creates a wood splinter particle effect.
        /// </summary>
        public static bool Wood(Vector3 position, Vector3 direction, int count = 1, float brightness = 1.0f)
        {
            return MtaClient.FxAddWood(position.X, position.Y, position.Z, direction.X, direction.Y, direction.Z, count, brightness);

        }
    }
}