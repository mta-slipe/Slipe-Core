using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;
using Slipe.Shared.Elements;
using Slipe.Shared.Weapons;
using System.ComponentModel;

namespace Slipe.Shared.Pickups
{
    /// <summary>
    /// Class representing a pickup element
    /// </summary>
    public class SharedPickup : PhysicalElement
    {
        #region Properties

        /// <summary>
        /// Gets the type of the pickup
        /// </summary>
        public PickupType PickupType
        {
            get
            {
                return (PickupType)MTAShared.GetPickupType(element);
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
        public WeaponType Weapon
        {
            get
            {
                return (WeaponType)MTAShared.GetPickupWeapon(element);
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

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public SharedPickup(MTAElement element) : base(element) { }

        /// <summary>
        /// Creates a pickup from all CreatePickup variables
        /// </summary>
        public SharedPickup(Vector3 position, PickupType type, int amount, int respawnTime = 30000, int ammo = 50)
        {
            element = MTAShared.CreatePickup(position.X, position.Y, position.Z, (int)type, amount, respawnTime, ammo);
            ElementManager.Instance.RegisterElement(this);
        }
        /// <summary>
        /// Creates a weapon pickup
        /// </summary>
        public SharedPickup(Vector3 position, WeaponType weapon, int ammo = 50, int respawnTime = 30000) : this(position, PickupType.Weapon, (int)weapon, respawnTime, ammo) { }

        /// <summary>
        /// Creates a custom pickup using GTA custom pickup models
        /// </summary>
        public SharedPickup(Vector3 position, PickupModel model, int respawnTime = 30000) : this(position, PickupType.Custom, (int)model, respawnTime) { }

        /// <summary>
        /// Creates a pickup object with any model
        /// </summary>
        public SharedPickup(Vector3 position, int model) : this(position, PickupType.Custom, model) { }

        #endregion

        #region Methods

        /// <summary>
        /// Morphs the pickup into a pickup of a different type
        /// </summary>
        public bool Morph(PickupType type, int amount, int ammo = 50)
        {
            return MTAShared.SetPickupType(element, (int)type, amount, ammo);
        }

        /// <summary>
        /// Morphs the pickup into a weapon pickup
        /// </summary>
        public bool Morph(WeaponType weapon, int ammo = 50)
        {
            return Morph(PickupType.Weapon, (int)weapon, ammo);
        }

        /// <summary>
        /// Morphs the pickup into a GTA custom pickup
        /// </summary>
        public bool Morph(PickupModel model)
        {
            return Morph(PickupType.Custom, (int)model);
        }

        /// <summary>
        /// Morphs the pickup into a model pickup taking any model ID
        /// </summary>
        public bool Morph(int model)
        {
            return Morph(PickupType.Custom, model);
        }

        #endregion

    }
}
