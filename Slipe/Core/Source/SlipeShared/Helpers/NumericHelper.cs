using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Slipe.Shared.Helpers
{
    /// <summary>
    /// Adds some required numeric translations
    /// </summary>
    public class NumericHelper
    {
        /// <summary>
        /// Convert degrees to radians
        /// </summary>
        public static float ToRadians(float x)
        {
            return x * (float)(Math.PI / 180.0);
        }

        /// <summary>
        /// Convert radians to degrees
        /// </summary>
        public static float ToDegrees(float x)
        {
            return (float)(x * (180.0 / Math.PI));
        }

        /// <summary>
        /// Translate an MTA Euler Rotation to a Quaternion
        /// </summary>
        public static Quaternion EulerToQuaternion(Vector3 rotation)
        {
            // Default is XYZ
            // Yaw = y-axis, Pitch = x-axis, Roll = z-axis
            return Quaternion.CreateFromYawPitchRoll(ToRadians(rotation.X), ToRadians(rotation.Y), ToRadians(rotation.Z));
        }

        /// <summary>
        /// Translate a Quaternion to an MTA Euler Rotation
        /// </summary>
        public static Vector3 QuaternionToEuler(Quaternion q)
        {
            float v1 = q.Z;
            float v2 = q.X;
            float v3 = q.Y;
            float v4 = q.W;


            double sinr_cosp = 2.0 * (v4 * v1 + v2 * v3);
            double cosr_cosp = 1.0 - 2.0 * (v1 * v1 + v2 * v2);
            double roll = Math.Atan2(sinr_cosp, cosr_cosp);


            double sinp = 2.0 * (v4 * v2 - v3 * v1);
            double pitch;
            if (Math.Abs(sinp) >= 1)
                pitch = Math.Sign(sinp) > 0 ? Math.PI : -Math.PI;
            else
                pitch = Math.Asin(sinp);


            double siny_cosp = 2.0 * (v4 * v3 + v1 * v2);
            double cosy_cosp = 1.0 - 2.0 * (v2 * v2 + v3 * v3);
            double yaw = Math.Atan2(siny_cosp, cosy_cosp);

            if (yaw < 0)
                yaw += 2 * Math.PI;

            if (pitch < 0)
                pitch += 2 * Math.PI;

            if (roll < 0)
                roll += 2 * Math.PI;

            return new Vector3(ToDegrees((float) yaw), ToDegrees((float) pitch), ToDegrees((float) roll));
        }
    }
}
