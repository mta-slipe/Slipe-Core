using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Weapons;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SlipeLua.Client.Peds.Events
{
    public class OnWeaponFireEventArgs
    {
        /// <summary>
        /// The weapon used
        /// </summary>
        public SharedWeaponModel Weapon { get; }

        /// <summary>
        /// The element hit, if any
        /// </summary>
        public PhysicalElement HitElement { get; }

        /// <summary>
        /// The world position of the hit
        /// </summary>
        public Vector3 HitPosition { get; }

        /// <summary>
        /// The total amount of ammo left
        /// </summary>
        public int AmmoLeft { get; }

        /// <summary>
        /// The ammo left in the clip
        /// </summary>
        public int AmmoLeftInClip { get; }

        internal OnWeaponFireEventArgs(dynamic weapon, dynamic ammoLeft, dynamic ammoLeftInClip, dynamic ex, dynamic ey, dynamic ez, MtaElement hitElement)
        {
            Weapon = new SharedWeaponModel((int)weapon);
            HitElement = ElementManager.Instance.GetElement<PhysicalElement>(hitElement);
            HitPosition = new Vector3((float) ex, (float) ey, (float) ez);
            AmmoLeft = (int)ammoLeft;
            AmmoLeftInClip = (int)ammoLeftInClip;
        }
    }
}
