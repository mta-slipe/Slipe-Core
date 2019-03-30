using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;
using Slipe.Shared;
using Slipe.Shared.Enums;

namespace Slipe.Client
{
    /// <summary>
    /// Class that wraps the huge amount of data that can be retrieved from SightLine Process
    /// </summary>
    public class SightLineData
    {
        private int piece;
        /// <summary>
        /// true if there is a collision, false otherwise
        /// </summary>
        public bool DidHit { get; }

        /// <summary>
        /// The colliision position
        /// </summary>
        public Vector3 CollisionPosition { get; }

        /// <summary>
        /// the MTA element hit if any, null otherwise
        /// </summary>
        public PhysicalElement HitElement { get; }

        /// <summary>
        /// GTASA material of the surface hit when applicable (world, objects)
        /// </summary>
        public SurfaceMaterialType SurfaceMaterial { get; }

        /// <summary>
        /// A float between 0 (fully dark) and 1 (bright) representing the amount of light that the hit building surface will transfer to peds or vehicles that are in contact with it. The value can be affected by the game time of day, usually with a lower (darker) value being returned during the night.
        /// </summary>
        public float Lighting { get; }

        /// <summary>
        /// The normal of the surface hit
        /// </summary>
        public Vector3 Normal { get; }

        /// <summary>
        /// For a ped/player, piece represents the body part hit:
        /// </summary>
        public BodyPart BodyPart
        {
            get
            {
                return (BodyPart)piece;
            }
        }

        /// <summary>
        /// For vehicles, piece represents the vehicle part hit:
        /// </summary>
        public VehiclePart VehiclePart
        {
            get
            {
                return (VehiclePart)piece;
            }
        }

        /// <summary>
        /// If IncludeWorldModelInformation was set to true and a world model was hit, this will contain the model ID.
        /// </summary>
        public int WorldModelID { get; }

        /// <summary>
        /// A matrix of the position and rotation of the world model
        /// </summary>
        public Matrix4x4 WorldModelMatrix { get; }

        /// <summary>
        /// If worldModelID is set, this will contain the LOD model ID if applicable.
        /// </summary>
        public int WorldLODModelID { get; }

        /// <summary>
        /// Create a data instance from the raw ProcessLineOfSight output
        /// </summary>
        public SightLineData(Tuple<bool, float, float, float, MTAElement, float, float, Tuple<float, int, float, int, int, float, float, Tuple<float, float, float, float, int>>> d)
        {
            DidHit = d.Item1;
            if(DidHit)
            {
                CollisionPosition = new Vector3(d.Item2, d.Item3, d.Item4);
                if (d.Item5 != null)
                    HitElement = (PhysicalElement) ElementManager.Instance.GetElement(d.Item5);
                Normal = new Vector3(d.Item6, d.Item7, d.Rest.Item1);
                SurfaceMaterial = (SurfaceMaterialType)d.Rest.Item2;
                Lighting = d.Rest.Item3;
                piece = d.Rest.Item4;
                WorldModelID = d.Rest.Item5;

                float v1 = d.Rest.Rest.Item2 * (float)(Math.PI / 180.0);
                float v2 = d.Rest.Rest.Item3 * (float)(Math.PI / 180.0);
                float v3 = d.Rest.Rest.Item4 * (float)(Math.PI / 180.0);

                WorldModelMatrix = Matrix4x4.CreateTranslation(d.Rest.Item6, d.Rest.Item7, d.Rest.Rest.Item1) + Matrix4x4.CreateFromQuaternion(Quaternion.CreateFromYawPitchRoll(v1, v2, v3));
                WorldLODModelID = d.Rest.Item5;
            }          

        }
    }
}
