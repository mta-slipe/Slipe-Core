using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using Slipe.Shared.Vehicles;
using Slipe.Shared.Weapons;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Slipe.Client.Vehicles.Events
{
    public class OnDamageEventArgs
    {
        /// <summary>
        /// The element that did the damage
        /// </summary>
        public PhysicalElement Attacker { get; }

        /// <summary>
        /// The weapon that was used, if any
        /// </summary>
        public SharedWeaponModel Weapon { get; }

        /// <summary>
        /// The damage taken
        /// </summary>
        public float Loss { get; }

        /// <summary>
        /// The world position of the damage
        /// </summary>
        public Vector3 Position { get; }

        /// <summary>
        /// The tire if a tire was damaged
        /// </summary>
        public Tire Tire { get; }

        internal OnDamageEventArgs(MtaElement attacker, dynamic weaponModel, dynamic loss, dynamic x, dynamic y, dynamic z, dynamic damagedTire)
        {
            Attacker = ElementManager.Instance.GetElement<PhysicalElement>(attacker);
            Weapon = new SharedWeaponModel((int)weaponModel);
            Loss = (float) loss;
            Position = new Vector3((float)x, (float)y, (float)z);
            Tire = (Tire)damagedTire;
        }
    }
}
