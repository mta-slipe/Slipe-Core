using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Weapons;
using System.ComponentModel;
using SlipeLua.Shared.Peds;
using SlipeLua.Shared.Pickups.Events;

namespace SlipeLua.Shared.Pickups
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
                return (PickupType)MtaShared.GetPickupType(element);
            }
        }

        /// <summary>
        /// Gets the ammo in the pickup if it's a weapon pickup
        /// </summary>
        public int Ammo
        {
            get
            {
                return MtaShared.GetPickupAmmo(element);
            }
        }

        /// <summary>
        /// Gets the weapon type of the pickup if it's a weapon pickup
        /// </summary>
        public SharedWeaponModel WeaponModel
        {
            get
            {
                return new SharedWeaponModel(MtaShared.GetPickupWeapon(element));
            }
        }

        /// <summary>
        /// Gets the amount of health or armour stored in the pickup
        /// </summary>
        public int Amount
        {
            get
            {
                return MtaShared.GetPickupAmount(element);
            }
        }

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public SharedPickup(MtaElement element) : base(element)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Morphs the pickup into a pickup of a different type
        /// </summary>
        public bool Morph(PickupType type, int amount, int ammo = 50)
        {
            return MtaShared.SetPickupType(element, (int)type, amount, ammo);
        }

        /// <summary>
        /// Morphs the pickup into a weapon pickup
        /// </summary>
        public bool Morph(SharedWeaponModel weapon, int ammo = 50)
        {
            return Morph(PickupType.Weapon, weapon.ID, ammo);
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

        #region Events
        #pragma warning disable 67

        public delegate void OnHitHandler(SharedPickup source, OnHitArgs eventArgs);
        public event OnHitHandler OnHit;

        public delegate void OnLeaveHandler(SharedPickup source, OnLeaveArgs eventArgs);
        public event OnLeaveHandler OnLeave;

        #pragma warning restore 67
        #endregion

    }
}
