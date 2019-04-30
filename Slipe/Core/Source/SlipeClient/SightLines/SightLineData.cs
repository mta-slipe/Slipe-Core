using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Numerics;
using Slipe.Shared.Vehicles;
using Slipe.Shared.Elements;
using Slipe.Shared.Peds;
using Slipe.Shared.Helpers;

namespace Slipe.Client.SightLines
{
    /// <summary>
    /// Class that wraps the huge amount of data that can be retrieved from SightLine Process
    /// </summary>
    public class SightLineData
    {
        private int piece;

        #region Properties

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
        public Part VehiclePart
        {
            get
            {
                return (Part)piece;
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

        #endregion

        /// <summary>
        /// Create a data instance from the raw ProcessLineOfSight output
        /// </summary>
        public SightLineData(Tuple<bool, float, float, float, MtaElement, float, float, Tuple<float, int, float, int, int, float, float, Tuple<float, float, float, float, int>>> d)
        {
            DidHit = d.Item1;
            if (DidHit)
            {
                CollisionPosition = new Vector3(d.Item2, d.Item3, d.Item4);
                if (d.Item5 != null)
                    HitElement = ElementManager.Instance.GetElement<PhysicalElement>(d.Item5);
                Normal = new Vector3(d.Item6, d.Item7, d.Rest.Item1);
                SurfaceMaterial = (SurfaceMaterialType)d.Rest.Item2;
                Lighting = d.Rest.Item3;
                piece = d.Rest.Item4;
                WorldModelID = d.Rest.Item5;

                WorldModelMatrix = Matrix4x4.CreateTranslation(d.Rest.Item6, d.Rest.Item7, d.Rest.Rest.Item1) + Matrix4x4.CreateFromQuaternion(NumericHelper.EulerToQuaternion(new Vector3(d.Rest.Rest.Item2, d.Rest.Rest.Item3, d.Rest.Rest.Item4)));
                WorldLODModelID = d.Rest.Item5;
            }

        }
    }
}
