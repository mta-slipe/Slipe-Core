using Slipe.Client.GameWorld;
using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Slipe.Client.Weapons.Events
{
    public class OnFireEventArgs
    {
        /// <summary>
        /// The element that was hit, if any
        /// </summary>
        public PhysicalElement HitElement { get; }

        /// <summary>
        /// The world position of the impact
        /// </summary>
        public Vector3 Position { get; }

        /// <summary>
        /// The normal of the impact
        /// </summary>
        public Vector3 Normal { get; }

        /// <summary>
        /// The material that was hit
        /// </summary>
        public SurfaceMaterialType Material { get; }

        /// <summary>
        /// The lighting at the impact
        /// </summary>
        public float Lighting { get; }

        /// <summary>
        /// The piece of the entity hit
        /// </summary>
        public int Piece { get; }

        internal OnFireEventArgs(MtaElement hitElement, dynamic x, dynamic y, dynamic z, dynamic nx, dynamic ny, dynamic nz, dynamic hitMaterial, dynamic lighting, dynamic partHit)
        {
            HitElement = ElementManager.Instance.GetElement<PhysicalElement>(hitElement);
            Position = new Vector3((float)x, (float)y, (float)z);
            Normal = new Vector3((float)nx, (float)ny, (float)nz);
            Material = (SurfaceMaterialType)hitMaterial;
            Lighting = (float)lighting;
            Piece = (int)partHit;
        }
    }
}
