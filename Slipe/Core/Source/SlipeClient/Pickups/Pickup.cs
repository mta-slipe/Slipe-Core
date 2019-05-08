using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Numerics;
using Slipe.Shared.Weapons;
using Slipe.Shared.Pickups;
using System.ComponentModel;
using Slipe.Shared.Elements;

namespace Slipe.Client.Pickups
{
    /// <summary>
    /// Class for a GTA pickup
    /// </summary>
    [DefaultElementClass(ElementType.Pickup)]
    public class Pickup : SharedPickup
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Pickup(MtaElement element) : base(element) { }

        /// <summary>
        /// Creates a pickup from all CreatePickup variables
        /// </summary>
        public Pickup(Vector3 position, PickupType type, int amount, int respawnTime = 30000, int ammo = 50)
            : this(MtaShared.CreatePickup(position.X, position.Y, position.Z, (int)type, amount, respawnTime, ammo)) { }

        /// <summary>
        /// Creates a pickup from the base createPickup paramters
        /// </summary>
        public Pickup(Vector3 position, PickupType type, int amount, int ammo = 50) 
            : this(position, type, amount, 0, ammo) { }

        /// <summary>
        /// Creates a weapon pickup
        /// </summary>
        public Pickup(Vector3 position, SharedWeaponModel weapon, int ammo = 50) 
            : this(position, PickupType.Weapon, weapon.ID, 0, ammo) { }

        /// <summary>
        /// Creates a custom model pickup
        /// </summary>
        public Pickup(Vector3 position, PickupModel model) 
            : this(position, PickupType.Custom, (int)model, 50) { }

        /// <summary>
        /// Creates a model pickup from any model ID
        /// </summary>
        public Pickup(Vector3 position, int model) 
            : this(position, PickupType.Custom, model, 50) { }
    }
}
