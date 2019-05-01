using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MtaDefinitions;
using Slipe.Shared.Peds;
using System.ComponentModel;
using Slipe.Shared.Weapons;
using Slipe.Server.Weapons;
using Slipe.Shared.Elements;

namespace Slipe.Server.Peds
{
    /// <summary>
    /// Represents a pedestrian 
    /// </summary>
    [DefaultElementClass("ped")]
    public class Ped : SharedPed
    {
        #region Properties

        /// <summary>
        /// Get and set the amount of armor of this ped
        /// </summary>
        public new float Armor
        {
            get
            {
                return MtaShared.GetPedArmor(element);
            }
            set
            {
                MtaServer.SetPedArmor(element, value);
            }
        }

        /// <summary>
        /// Get and set the fighting style of the ped
        /// </summary>
        public new FightingStyle FightingStyle
        {
            get
            {
                return (FightingStyle)MtaShared.GetPedFightingStyle(element);
            }
            set
            {
                MtaServer.SetPedFightingStyle(element, (int)value);
            }
        }

        /// <summary>
        /// This function returns the current gravity for this ped. The default gravity is 0.008.
        /// </summary>
        public float Gravity
        {
            get
            {
                return MtaServer.GetPedGravity(element);
            }
            set
            {
                MtaServer.SetPedGravity(element, value);
            }
        }

        /// <summary>
        /// Get and set if the ped is choking
        /// </summary>
        public new bool Chocking
        {
            get
            {
                return MtaShared.IsPedChoking(element);
            }
            set
            {
                MtaServer.SetPedChoking(element, value);
            }
        }

        /// <summary>
        /// Get and set if the ped has a jetpack
        /// </summary>
        public new bool HasJetpack
        {
            get
            {
                return MtaShared.IsPedWearingJetpack(element);
            }
            set
            {
                MtaServer.SetPedWearingJetpack(element, value);
            }
        }

        #endregion 

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Ped(MtaElement element) : base(element)
        {

        }

        /// <summary>
        /// Create a new ped
        /// </summary>
        public Ped(PedModel model, Vector3 position, float rotation = 0.0f, bool synced = true)
            : this (MtaServer.CreatePed((int)model, position.X, position.Y, position.Z, rotation, synced)) { }

        #endregion

        #region Methods

        /// <summary>
        /// This function reloads the weapon of this ped
        /// </summary>
        public bool ReloadWeapon()
        {
            return MtaServer.ReloadPedWeapon(element);
        }

        /// <summary>
        /// Give a weapon to this ped
        /// </summary>
        public bool GiveWeapon(SharedWeaponModel model, int ammo = 30, bool setAsCurrent = false)
        {
            return MtaServer.GiveWeapon(element, model.ID, ammo, setAsCurrent);
        }

        /// <summary>
        /// Set the total ammo of a weapon the ped has
        /// </summary>
        public bool SetAmmo(SharedWeaponModel model, int totalAmmo, int ammoInClip = 0)
        {
            return MtaShared.SetWeaponAmmo(element, model.ID, totalAmmo, ammoInClip);
        }

        /// <summary>
        /// Take all weapons from this ped
        /// </summary>
        public bool TakeAllWeapons()
        {
            return MtaServer.TakeAllWeapons(element);
        }

        /// <summary>
        /// Take a weapon from a player
        /// </summary>
        public bool TakeWeapon(SharedWeaponModel model)
        {
            return MtaServer.TakeWeapon(element, model.ID, -1);
        }

        /// <summary>
        /// Take a certain amount of ammo from a player weapon
        /// </summary>
        public bool TakeAmmo(SharedWeaponModel model, int amount)
        {
            return MtaServer.TakeWeapon(element, model.ID, amount);
        }

        #endregion

        #region Events

        #pragma warning disable 67

        public delegate void OnWastedHandler(int remainingAmmo, Player attacker, DamageType damageType, BodyPart bodyPart, bool stealth);
        public event OnWastedHandler OnWasted;

        public delegate void OnWeaponSwitchHandler(WeaponModel previousWeapon, WeaponModel newWeapon);
        public event OnWeaponSwitchHandler OnWeaponSwitch;

        #pragma warning restore 67

        #endregion
    }

}
