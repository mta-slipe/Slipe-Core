using SlipeLua.MtaDefinitions;
using SlipeLua.Server.Weapons;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SlipeLua.Server.Peds.Events
{
    public class OnWeaponFireEventArgs
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

        internal OnWeaponFireEventArgs(dynamic weapon, dynamic ex, dynamic ey, dynamic ez, MtaElement hitElement, dynamic sx, dynamic sy, dynamic sz)
        {
            Weapon = new WeaponModel((int)weapon);
            HitElement = ElementManager.Instance.GetElement<PhysicalElement>(hitElement);
            EndPosition = new Vector3((float) ex, (float) ey, (float) ez);
            StartPosition = new Vector3((float) sx, (float)sy, (float)sz);
        }
    }
}
