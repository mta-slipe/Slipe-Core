﻿using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;
using System.Numerics;
using SlipeLua.Shared.Weapons;
using SlipeLua.Shared.Elements;
using System.ComponentModel;
using SlipeLua.Client.Vehicles;
using SlipeLua.Shared.Vehicles;
using SlipeLua.Client.Peds;
using SlipeLua.Shared.Peds;
using SlipeLua.Client.SightLines;
using SlipeLua.Client.Weapons.Events;

namespace SlipeLua.Client.Weapons
{
    /// <summary>
    /// Represents a custom weapon that can be placed in the world
    /// </summary>
    [DefaultElementClass(ElementType.Weapon)]
    public class CustomWeapon : PhysicalElement
    {
        #region Properties

        /// <summary>
        /// Get and set the ammo of this weapon
        /// </summary>
        public int Ammo
        {
            get
            {
                return MtaClient.GetWeaponAmmo(element);
            }
            set
            {
                MtaShared.SetWeaponAmmo(element, value, -1, -1);
            }
        }

        /// <summary>
        /// Get and set the ammo currently in the clip
        /// </summary>
        public int AmmoInClip
        {
            get
            {
                return MtaClient.GetWeaponClipAmmo(element);
            }
            set
            {
                MtaClient.SetWeaponClipAmmo(element, value);
            }
        }

        /// <summary>
        /// Set the firing rate of this weapon
        /// </summary>
        public int FiringRate
        {
            get
            {
                return MtaClient.GetWeaponFiringRate(element);
            }
            set
            {
                MtaClient.SetWeaponFiringRate(element, value);
            }
        }

        /// <summary>
        /// Get and set the state of this weapon
        /// </summary>
        public WeaponState State
        {
            get
            {
                return (WeaponState) Enum.Parse(typeof(WeaponState), MtaClient.GetWeaponState(element), true);
            }
            set
            {
                MtaClient.SetWeaponState(element, value.ToString().ToLower());
            }
        }

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public CustomWeapon(MtaElement element) : base(element) { }

        /// <summary>
        /// Create a custom weapon at a certain position
        /// </summary>
        public CustomWeapon(SharedWeaponModel model, Vector3 position)
            : this(MtaClient.CreateWeapon(model.Name, position.X, position.Y, position.Z)) { }

        #endregion

        #region Methods

        /// <summary>
        /// Fire the weapon!
        /// </summary>
        public bool Fire()
        {
            return MtaClient.FireWeapon(element);
        }

        /// <summary>
        /// Have the weapon target a vehicle tire
        /// </summary>
        public bool SetTarget(BaseVehicle vehicle, Tire tire)
        {
            return MtaClient.SetWeaponTarget(element, vehicle.MTAElement, (int)tire);
        }

        /// <summary>
        /// Have the weapon target the center of any element (vehicle, ped, player, world object)
        /// </summary>
        public bool SetTarget(PhysicalElement physicalElement)
        {
            return MtaClient.SetWeaponTarget(element, physicalElement.MTAElement, 255);
        }

        /// <summary>
        /// Have the weapon target a ped at a specific bone
        /// </summary>
        public bool SetTarget(Ped ped, Bone bone)
        {
            return MtaClient.SetWeaponTarget(element, ped.MTAElement, (int) bone);
        }

        /// <summary>
        /// Have the weapon target a position
        /// </summary>
        public bool SetTarget(Vector3 position)
        {
            return MtaClient.SetWeaponTarget(element, position.X, position.Y, position.Z);
        }

        /// <summary>
        /// Have the weapon target along its rotation
        /// </summary>
        public bool SetTarget()
        {
            return MtaClient.SetWeaponTarget(element);
        }

        /// <summary>
        /// Reset the firing rate of this weapon
        /// </summary>
        public bool ResetFiringRate()
        {
            return MtaClient.ResetWeaponFiringRate(element);
        }

        #endregion

        #region Events

        #pragma warning disable 67

        public delegate void OnFireHandler(CustomWeapon source, OnFireEventArgs eventArgs);
        public event OnFireHandler OnFire;

        #pragma warning restore 67

        #endregion
    }
}
