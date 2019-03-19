using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.Shared.Enums;
using Slipe.MTADefinitions;


namespace Slipe.Shared
{
    /// <summary>
    /// Class representing a pickup element
    /// </summary>
    public class SharedPickup : PhysicalElement
    {
        /// <summary>
        /// Creates or retrieves a pickup from an MTA pickup element
        /// </summary>
        public SharedPickup(MTAElement element) : base(element) { }

        /// <summary>
        /// Creates a pickup from all CreatePickup variables
        /// </summary>
        public SharedPickup(Vector3 position, PickupTypeEnum type, int amount, int respawnTime = 30000, int ammo = 50)
        {
            element = MTAShared.CreatePickup(position.X, position.Y, position.Z, (int) type, amount, respawnTime, ammo);
            ElementManager.Instance.RegisterElement(this);
        }
        /// <summary>
        /// Creates a weapon pickup
        /// </summary>
        public SharedPickup(Vector3 position, WeaponEnum weapon, int ammo = 50, int respawnTime = 30000) : this(position, PickupTypeEnum.WEAPON, (int) weapon, respawnTime, ammo) { }

        /// <summary>
        /// Creates a custom pickup using GTA custom pickup models
        /// </summary>
        public SharedPickup(Vector3 position, PickupModelEnum model, int respawnTime = 30000) : this(position, PickupTypeEnum.CUSTOM, (int )model, respawnTime) { }

        /// <summary>
        /// Creates a pickup object with any model
        /// </summary>
        public SharedPickup(Vector3 position, int model) : this(position, PickupTypeEnum.CUSTOM, model) { }

        /// <summary>
        /// Gets the type of the pickup
        /// </summary>
        public PickupTypeEnum PickupType
        {
            get
            {
                return (PickupTypeEnum) MTAShared.GetPickupType(element);
            }
        }

        /// <summary>
        /// Gets the ammo in the pickup if it's a weapon pickup
        /// </summary>
        public int Ammo
        {
            get
            {
                return MTAShared.GetPickupAmmo(element);
            }
        }

        /// <summary>
        /// Gets the weapon type of the pickup if it's a weapon pickup
        /// </summary>
        public WeaponEnum Weapon
        {
            get
            {
                return (WeaponEnum)MTAShared.GetPickupWeapon(element);
            }
        }

        /// <summary>
        /// Gets the amount of health or armour stored in the pickup
        /// </summary>
        public int Amount
        {
            get
            {
                return MTAShared.GetPickupAmount(element);
            }
        }

        /// <summary>
        /// Morphs the pickup into a pickup of a different type
        /// </summary>
        public bool Morph(PickupTypeEnum type, int amount, int ammo = 50)
        {
            return MTAShared.SetPickupType(element, (int)type, amount, ammo);
        }

        /// <summary>
        /// Morphs the pickup into a weapon pickup
        /// </summary>
        public bool Morph(WeaponEnum weapon, int ammo = 50)
        {
            return Morph(PickupTypeEnum.WEAPON, (int)weapon, ammo);
        }

        /// <summary>
        /// Morphs the pickup into a GTA custom pickup
        /// </summary>
        public bool Morph(PickupModelEnum model)
        {
            return Morph(PickupTypeEnum.CUSTOM, (int)model);
        }

        /// <summary>
        /// Morphs the pickup into a model pickup taking any model ID
        /// </summary>
        public bool Morph(int model)
        {
            return Morph(PickupTypeEnum.CUSTOM, model);
        }

    }
}
