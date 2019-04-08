using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Slipe.Shared.Elements;
using Slipe.Shared.Utilities;
using Slipe.Server.Peds;
using Slipe.Shared.Rendering;

namespace Slipe.Server.Rendering
{
    /// <summary>
    /// The camera object attached to a player
    /// </summary>
    public class Camera
    {
        private Player player;

        /// <summary>
        /// Creates a new camera instance from a player
        /// </summary>
        public Camera(Player player)
        {
            this.player = player;
        }

        /// <summary>
        /// Get and set the target of this camera
        /// </summary>
        public Element Target
        {
            get
            {
                return ElementManager.Instance.GetElement(MtaServer.GetCameraTarget(player.MTAElement));
            }
            set
            {
                MtaServer.SetCameraTarget(player.MTAElement, value.MTAElement);
            }
        }

        /// <summary>
        /// Get and set the interior of this camera
        /// </summary>
        public int Interior
        {
            get
            {
                return MtaServer.GetCameraInterior(player.MTAElement);
            }
            set
            {
                MtaServer.SetCameraInterior(player.MTAElement, value);
            }
        }

        /// <summary>
        /// Sets the matrix of this camera using a 4x4 matrix, roll and field of view
        /// </summary>
        public bool SetMatrix(Matrix4x4 matrix, float roll = 0, float fov = 70)
        {
            throw new NotImplementedException();

            //Vector3 translation = matrix.Translation;
            //Vector3 forward = matrix.Forward;
            //Vector3 lookAt = translation + forward;

            //return MTAServer.SetCameraMatrix(player.MTAElement, translation.X, translation.Y, translation.Z, lookAt.X, lookAt.Y, lookAt.Z, roll, fov);
        }

        /// <summary>
        /// Sets the matrix of this camera using two vectors, roll and field of view
        /// </summary>
        public bool SetMatrix(Vector3 position, Vector3 lookAt, float roll = 0, float fov = 70)
        {
            return MtaServer.SetCameraMatrix(player.MTAElement, position.X, position.Y, position.Z, lookAt.X, lookAt.Y, lookAt.Z, roll, fov);
        }

        /// <summary>
        /// Retrieve the position, lookat, roll and field of view of a camera
        /// </summary>
        public Tuple<Vector3, Vector3, float, float> GetFullCameraMatrix()
        {
            Tuple<float, float, float, float, float, float, float, float> result = MtaServer.GetCameraMatrix(player.MTAElement);
            Vector3 position = new Vector3(result.Item1, result.Item2, result.Item3);
            Vector3 rotation = new Vector3(result.Item4, result.Item5, result.Item6);
            float roll = result.Item7;
            float yaw = result.Rest;
            return new Tuple<Vector3, Vector3, float, float>(position, rotation, roll, yaw);
        }

        /// <summary>
        /// Retrieves the 4x4matrix of this camera
        /// </summary>
        public Matrix4x4 GetCameraMatrix()
        {
            throw new NotImplementedException();

            //Tuple<float, float, float, float, float, float, float, float> result = MTAServer.GetCameraMatrix(player.MTAElement);
            //Vector3 position = new Vector3(result.Item1, result.Item2, result.Item3);
            //Vector3 rotation = new Vector3(result.Item4, result.Item5, result.Item6);
            //float roll = result.Item7;
            //float yaw = result.Rest;
            //return Matrix4x
        }

        /// <summary>
        /// Fade the camera to a specific color in a certain time
        /// </summary>
        public bool Fade(CameraFade fade, Color color, int time = 1000)
        {
            return MtaServer.FadeCamera(player.MTAElement, fade == CameraFade.In ? true : false, time / 1000, color.R, color.G, color.B);
        }

        /// <summary>
        /// Fade to black \m/
        /// </summary>
        public bool Fade(CameraFade fade)
        {
            return Fade(fade, new Color(0x000000));
        }

    }
}
