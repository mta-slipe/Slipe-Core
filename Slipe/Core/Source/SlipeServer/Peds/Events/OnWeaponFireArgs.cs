using Slipe.Server.Weapons;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnWeaponFireArgs
    {
        /// <summary>
        /// The weapon used
        /// </summary>
        public WeaponModel Weapon { get; }

        /// <summary>
        /// The element hit, if any
        /// </summary>
        public PhysicalElement HitElement { get; }

        /// <summary>
        /// The world position of the hit
        /// </summary>
        public Vector3 EndPosition { get; }

        /// <summary>
        /// The world position of the start of the bullet
        /// </summary>
        public Vector3 StartPosition { get; }

        internal OnWeaponFireArgs(WeaponModel weapon, Vector3 endPosition, PhysicalElement hitElement, Vector3 startPosition)
        {
            Weapon = weapon;
            HitElement = hitElement;
            EndPosition = endPosition;
            StartPosition = startPosition;
        }
    }
}
