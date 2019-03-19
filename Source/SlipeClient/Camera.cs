using Slipe.Client.Enums;
using Slipe.Shared;
using Slipe.Shared.Enums;
using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Slipe.Client
{
    /// <summary>
    /// Class representing the camera of the local player
    /// </summary>
    public class Camera
    {
        private static Camera instance;
        public static Camera Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Camera();
                }
                return instance;
            }
        }

        public Camera()
        {
        }

        /// <summary>
        /// Get and set the target of the camera
        /// </summary>
        public PhysicalElement Target
        {
            get
            {
                return (PhysicalElement) ElementManager.Instance.GetElement(MTAClient.GetCameraTarget());
            }
            set
            {
                MTAClient.SetCameraTarget(value.MTAElement);
            }
        }

        /// <summary>
        /// Get and set the interior the camera is in
        /// </summary>
        public int Interior
        {
            get
            {
                return MTAClient.GetCameraInterior();
            }
            set
            {
                MTAClient.SetCameraInterior(value);
            }
        }

        /// <summary>
        /// This property sets the distance from the camera at which the world starts rendering. 
        /// </summary>
        public float NearClipDistance
        {
            get
            {
                return MTAClient.GetNearClipDistance();
            }
            set
            {
                MTAClient.SetNearClipDistance(value);
            }
        }

        /// <summary>
        /// Get and set the viewmode of the camera
        /// </summary>
        public CameraViewMode ViewMode
        {
            get
            {
                return (CameraViewMode) MTAClient.GetCameraViewMode();
            }
            set
            {
                MTAClient.SetCameraViewMode((int)value);
            }
        }
        
        /// <summary>
        /// Get and set the shake level of the camera
        /// </summary>
        public byte ShakeLevel
        {
            get
            {
                return (byte) MTAClient.GetCameraShakeLevel();
            }
            set
            {
                MTAClient.SetCameraShakeLevel(value);
            }
        }

        /// <summary>
        /// Get and set the 4x4matrix, roll and field of view on the camera
        /// </summary>
        public bool SetMatrix(Matrix4x4 matrix, float roll = 0, float fov = 70)
        {
            throw new NotImplementedException();

            //Vector3 translation = matrix.Translation;
            //Vector3 forward = matrix.Forward;
            //Vector3 lookAt = translation + forward;

            //return MTAClient.SetCameraMatrix(player.MTAElement, translation.X, translation.Y, translation.Z, lookAt.X, lookAt.Y, lookAt.Z, roll, fov);
        }

        /// <summary>
        /// Get and set the matrix, roll and fox using vector3s for position and lookAt
        /// </summary>
        public bool SetMatrix(Vector3 position, Vector3 lookAt, float roll = 0, float fov = 70)
        {
            return MTAClient.SetCameraMatrix(position.X, position.Y, position.Z, lookAt.X, lookAt.Y, lookAt.Z, roll, fov);
        }

        /// <summary>
        /// Retrieve the full camera matrix
        /// </summary>
        public Tuple<Vector3, Vector3, float, float> GetFullCameraMatrix()
        {
            Tuple<float, float, float, float, float, float, float, float> result = MTAClient.GetCameraMatrix();
            Vector3 position = new Vector3(result.Item1, result.Item2, result.Item3);
            Vector3 rotation = new Vector3(result.Item4, result.Item5, result.Item6);
            float roll = result.Item7;
            float yaw = result.Rest;
            return new Tuple<Vector3, Vector3, float, float>(position, rotation, roll, yaw);
        }

        /// <summary>
        /// Retrieve the camera matrix as a matrix4x4 representation
        /// </summary>
        public Matrix4x4 GetCameraMatrix()
        {
            throw new NotImplementedException();

            //Tuple<float, float, float, float, float, float, float, float> result = MTAClient.GetCameraMatrix(player.MTAElement);
            //Vector3 position = new Vector3(result.Item1, result.Item2, result.Item3);
            //Vector3 rotation = new Vector3(result.Item4, result.Item5, result.Item6);
            //float roll = result.Item7;
            //float yaw = result.Rest;
            //return Matrix4x
        }

        /// <summary>
        /// Fade the camera to a color in a specific time
        /// </summary>
        public bool Fade(CameraFade fade, Color color, int time = 1000)
        {
            return MTAClient.FadeCamera(fade == CameraFade.IN ? true : false, time / 1000, color.R, color.G, color.B);
        }

        /// <summary>
        /// Fade to Black \m/
        /// </summary>
        public bool Fade(CameraFade fade)
        {
            return Fade(fade, new Color(0x000000));
        }

        /// <summary>
        /// Set the field of view of this camera on a specific mode
        /// </summary>
        public bool SetFieldOfView(CameraMode mode, float fieldOfView)
        {
            return MTAClient.SetCameraFieldOfView(mode.ToString("f").ToLower(), fieldOfView);
        }

        /// <summary>
        /// Get the field of view of a specific mode of the camera
        /// </summary>
        public float GetFieldOfView(CameraMode mode)
        {
            return MTAClient.GetCameraFieldOfView(mode.ToString("f").ToLower());
        }

        /// <summary>
        /// Set the goggle effect of this camera
        /// </summary>
        public bool SetGoggleEffect(GoggleEffects effect, bool noiseEnabled = true)
        {
            return MTAClient.SetCameraGoggleEffect(effect.ToString("f").ToLower(), noiseEnabled);
        }

        /// <summary>
        /// Get the Goggleeffect of this camera
        /// </summary>
        public string GetGoggleEffect()
        {
            return MTAClient.GetCameraGoggleEffect();
        }

        /// <summary>
        /// Set if this camera clips with objects and/or vehicles
        /// </summary>
        public bool SetCameraClip(bool objects = true, bool vehicles = true)
        {
            return MTAClient.SetCameraClip(objects, vehicles);
        }

        /// <summary>
        /// Get the clip settings of the camera
        /// </summary>
        public Tuple<bool, bool> GetCameraClip()
        {
            return MTAClient.GetCameraClip();
        }

        /// <summary>
        /// This function gets the screen position of a point in the world.
        /// </summary>
        public Vector2 GetScreenFromWorldPosition(Vector3 position, float edgeTolerance = 0.0f, bool relative = true)
        {
            Tuple<float, float> result = MTAClient.GetScreenFromWorldPosition(position.X, position.Y, position.Z, edgeTolerance, relative);
            return new Vector2(result.Item1, result.Item2);
        }

        /// <summary>
        /// This function allows you to retrieve the world position corresponding to a 2D position on the screen, at a certain depth.
        /// </summary>
        public Vector3 GetWorldFromScreenPosition(Vector2 position, float depth)
        {
            Tuple<float, float, float> result = MTAClient.GetWorldFromScreenPosition(position.X, position.Y, depth);
            return new Vector3(result.Item1, result.Item2, result.Item3);
        }

        /// <summary>
        /// This function checks if there are obstacles between two points of the game world, optionally ignoring certain kinds of elements. Use processLineOfSight if you want more information about what the ray hits.
        /// </summary>
        public bool IsLineOfSightClear(Vector3 start, Vector3 end, bool checkBuildings = true, bool checkVehicles = true, bool checkPeds = true, bool checkObjects = true, bool checkDummies = true, bool seeThroughStuff = false, bool ignoreSomeObjectsForCamera = false, PhysicalElement ignoredElement = null)
        {
            return MTAClient.IsLineOfSightClear(start.X, start.Y, start.Z, end.X, end.Y, end.Z, checkBuildings, checkVehicles, checkPeds, checkObjects, checkDummies, seeThroughStuff, ignoreSomeObjectsForCamera, ignoredElement?.MTAElement);
        }

    }
}
