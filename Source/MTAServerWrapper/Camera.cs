using MTASharedWrapper;
using MTASharedWrapper.Enums;
using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MTAServerWrapper
{
    public class Camera
    {
        private Player player;

        public Camera(Player player)
        {
            this.player = player;
        }

        public Element Target
        {
            get
            {
                return ElementManager.Instance.GetElement(Server.GetCameraTarget(player.MTAElement));
            }
            set
            {
                Server.SetCameraTarget(player.MTAElement, value.MTAElement);
            }
        }

        public int Interior
        {
            get
            {
                return Server.GetCameraInterior(player.MTAElement);
            }
            set
            {
                Server.SetCameraInterior(player.MTAElement, value);
            }
        }

        public bool SetMatrix(Matrix4x4 matrix, float roll = 0, float fov = 70)
        {
            throw new NotImplementedException();

            //Vector3 translation = matrix.Translation;
            //Vector3 forward = matrix.Forward;
            //Vector3 lookAt = translation + forward;

            //return Server.SetCameraMatrix(player.MTAElement, translation.X, translation.Y, translation.Z, lookAt.X, lookAt.Y, lookAt.Z, roll, fov);
        }

        public bool SetMatrix(Vector3 position, Vector3 lookAt, float roll = 0, float fov = 70)
        {
            return Server.SetCameraMatrix(player.MTAElement, position.X, position.Y, position.Z, lookAt.X, lookAt.Y, lookAt.Z, roll, fov);
        }

        public Tuple<Vector3, Vector3, float, float> GetFullCameraMatrix()
        {
            Tuple<float, float, float, float, float, float, float, float> result = Server.GetCameraMatrix(player.MTAElement);
            Vector3 position = new Vector3(result.Item1, result.Item2, result.Item3);
            Vector3 rotation = new Vector3(result.Item4, result.Item5, result.Item6);
            float roll = result.Item7;
            float yaw = result.Rest;
            return new Tuple<Vector3, Vector3, float, float>(position, rotation, roll, yaw);
        }

        public Matrix4x4 GetCameraMatrix()
        {
            throw new NotImplementedException();

            //Tuple<float, float, float, float, float, float, float, float> result = Server.GetCameraMatrix(player.MTAElement);
            //Vector3 position = new Vector3(result.Item1, result.Item2, result.Item3);
            //Vector3 rotation = new Vector3(result.Item4, result.Item5, result.Item6);
            //float roll = result.Item7;
            //float yaw = result.Rest;
            //return Matrix4x
        }

        public bool Fade(CameraFade fade, Color color, int time = 1000)
        {
            return Server.FadeCamera(player.MTAElement, fade == CameraFade.IN ? true : false, time / 1000, color.R, color.G, color.B);
        }

        public bool Fade(CameraFade fade)
        {
            return Fade(fade, new Color(0x000000));
        }

    }
}
