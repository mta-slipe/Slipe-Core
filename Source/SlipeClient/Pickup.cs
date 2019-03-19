using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared;
using Slipe.Shared.Enums;
using Slipe.MTADefinitions;
using System.Numerics;

namespace Slipe.Client
{
    /// <summary>
    /// Class for a GTA pickup
    /// </summary>
    public class Pickup : SharedPickup
    {
        /// <summary>
        /// Creates or retrieves a pickup from an MTA pickup element
        /// </summary>
        public Pickup(MTAElement element) : base(element) { }

        /// <summary>
        /// Creates a pickup from the base createPickup paramters
        /// </summary>
        public Pickup(Vector3 position, PickupTypeEnum type, int amount, int ammo = 50) : base (position, type, amount, 0, ammo) { }

        /// <summary>
        /// Creates a weapon pickup
        /// </summary>
        public Pickup(Vector3 position, WeaponEnum weapon, int ammo = 50) : base (position, PickupTypeEnum.WEAPON, (int)weapon, 0, ammo) { }

        /// <summary>
        /// Creates a custom model pickup
        /// </summary>
        public Pickup(Vector3 position, PickupModelEnum model) : base (position, PickupTypeEnum.CUSTOM, (int) model) { }

        /// <summary>
        /// Creates a model pickup from any model ID
        /// </summary>
        public Pickup(Vector3 position, int model) : base (position, PickupTypeEnum.CUSTOM, model) { }
    }
}
