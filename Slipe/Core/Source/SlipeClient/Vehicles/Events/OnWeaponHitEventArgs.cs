using SlipeLua.Client.GameWorld;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Vehicles;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SlipeLua.Client.Vehicles.Events
{
    public class OnWeaponHitEventArgs
    {
        /// <summary>
        /// The type of the weapon
        /// </summary>
        public Weapon WeaponType { get; }

        /// <summary>
        /// The element that was hit, if any
        /// </summary>
        public PhysicalElement HitElement { get; }

        /// <summary>
        /// The world position of the impact
        /// </summary>
        public Vector3 Position { get; }

        /// <summary>
        /// The material that was hit
        /// </summary>
        public SurfaceMaterialType Material { get; }

        /// <summary>
        /// The model of the element that was hit
        /// </summary>
        public int Model { get; }

        internal OnWeaponHitEventArgs(dynamic weaponType, dynamic hitElement, dynamic x, dynamic y, dynamic z, dynamic hitModel, dynamic materialId)
        {
            WeaponType = (Weapon)weaponType;
            HitElement = ElementManager.Instance.GetElement<PhysicalElement>(hitElement);
            Position = new Vector3((float)x, (float)y, (float)z);
            Material = (SurfaceMaterialType)materialId;
            Model = (int)hitModel;

        }
    }
}
