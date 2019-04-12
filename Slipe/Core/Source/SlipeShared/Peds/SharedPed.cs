using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using Slipe.Shared.Vehicles;
using Slipe.Shared.Elements;
using Slipe.Shared.Weapons;
using System.ComponentModel;

namespace Slipe.Shared.Peds
{
    /// <summary>
    /// Represents a pedestrian with shared server/client functionality
    /// </summary>
    public class SharedPed : PhysicalElement
    {
        #region Properties

        /// <summary>
        /// Get and set the current weaponslot of the ped
        /// </summary>
        public WeaponSlot WeaponSlot
        {
            get
            {
                return (WeaponSlot)MtaShared.GetPedWeaponSlot(element);
            }
            set
            {
                MtaShared.SetPedWeaponSlot(element, (int)value);
            }
        }

        /// <summary>
        /// Get the amount of armor of this ped
        /// </summary>
        public float Armor
        {
            get
            {
                return MtaShared.GetPedArmor(element);
            }
        }

        /// <summary>
        /// This function detects the element a ped is standing on.
        /// </summary>
        public PhysicalElement ContactElement
        {
            get
            {
                try
                {
                    return (PhysicalElement)ElementManager.Instance.GetElement(MtaShared.GetPedContactElement(element));
                }
                catch (MtaException)
                {
                    return null;
                }

            }
        }

        /// <summary>
        /// Get the fighting style of the ped
        /// </summary>
        public FightingStyle FightingStyle
        {
            get
            {
                return (FightingStyle)MtaShared.GetPedFightingStyle(element);
            }
        }

        /// <summary>
        /// This function gets the vehicle that the ped is currently in or is trying to enter, if any.
        /// </summary>
        public SharedVehicle OccupiedVehicle
        {
            get
            {
                try
                {
                    return (SharedVehicle)ElementManager.Instance.GetElement(MtaShared.GetPedOccupiedVehicle(element));
                }
                catch (MtaException)
                {
                    return null;
                }

            }
        }

        /// <summary>
        /// Get the seat the ped occupies
        /// </summary>
        public Seat VehicleSeat
        {
            get
            {
                try
                {
                    return (Seat)MtaShared.GetPedOccupiedVehicleSeat(element);
                }
                catch (MtaException)
                {
                    return Seat.None;
                }

            }
        }

        /// <summary>
        /// Get if the ped is choking
        /// </summary>
        public bool Chocking
        {
            get
            {
                return MtaShared.IsPedChoking(element);
            }
        }

        /// <summary>
        /// Check if the ped is dead
        /// </summary>
        public bool IsDead
        {
            get
            {
                return MtaShared.IsPedDead(element);
            }
        }

        /// <summary>
        /// Get and set if the ped is doing a gang driveby
        /// </summary>
        public bool DoingGangDriveby
        {
            get
            {
                return MtaShared.IsPedDoingGangDriveby(element);
            }
            set
            {
                MtaShared.SetPedDoingGangDriveby(element, value);
            }
        }

        /// <summary>
        /// Get if the ped is ducked (crouched)
        /// </summary>
        public bool IsDucked
        {
            get
            {
                return MtaShared.IsPedDucked(element);
            }
        }

        /// <summary>
        /// Get and set if the ped is headless
        /// </summary>
        public bool Headless
        {
            get
            {
                return MtaShared.IsPedHeadless(element);
            }
            set
            {
                MtaShared.SetPedHeadless(element, value);
            }
        }

        /// <summary>
        /// Get if the ped is in a vehicle
        /// </summary>
        public bool IsInVehicle
        {
            get
            {
                return MtaShared.IsPedInVehicle(element);
            }
        }

        /// <summary>
        /// Get and set if the ped is on fire
        /// </summary>
        public bool OnFire
        {
            get
            {
                return MtaShared.IsPedOnFire(element);
            }
            set
            {
                MtaShared.SetPedOnFire(element, value);
            }
        }

        /// <summary>
        /// Get if the ped is standing on the ground
        /// </summary>
        public bool IsOnGround
        {
            get
            {
                return MtaShared.IsPedOnGround(element);
            }
        }

        /// <summary>
        /// Get if the ped has a jetpack
        /// </summary>
        public bool HasJetpack
        {
            get
            {
                return MtaShared.IsPedWearingJetpack(element);
            }
        }

        /// <summary>
        /// Get the element this ped is currently targeting
        /// </summary>
        public PhysicalElement Target
        {
            get
            {
                try
                {
                    return (PhysicalElement)ElementManager.Instance.GetElement(MtaShared.GetPedTarget(element));
                }
                catch (MtaException)
                {
                    return null;
                }

            }
        }

        /// <summary>
        /// Get and set the walking style of this ped
        /// </summary>
        public WalkingStyle WalkingStyle
        {
            get
            {
                return (WalkingStyle)MtaShared.GetPedWalkingStyle(element);
            }
            set
            {
                MtaShared.SetPedWalkingStyle(element, (int)value);
            }
        }

        /// <summary>
        /// Get the current weapon
        /// </summary>
        public SharedWeaponModel Weapon
        {
            get
            {
                return new SharedWeaponModel(MtaShared.GetPedWeapon(element, (int)WeaponSlot));
            }
        }

        /// <summary>
        /// Get the ammo in the clip of the current weapon
        /// </summary>
        public int AmmoInClip
        {
            get
            {
                return MtaShared.GetPedAmmoInClip(element, (int)WeaponSlot);
            }
        }

        /// <summary>
        /// Get the total ammo in the current weaponslot
        /// </summary>
        public int TotalAmmo
        {
            get
            {
                return MtaShared.GetPedTotalAmmo(element, (int)WeaponSlot);
            }
        }

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public SharedPed(MtaElement element) : base(element) { }

        #endregion

        #region Clothes Methods
        protected bool IsClothesSlotTattoo(ClothesSlot slot)
        {
            return (int)slot > 3 && (int)slot < 13;
        }

        /// <summary>
        /// This function is used to set the current clothes on the ped.
        /// </summary>
        public bool AddClothes(ClothesTexture texture, ClothesModel model, ClothesSlot slot)
        {
            string t = texture.ToString();
            string m = model.ToString();
            if (IsClothesSlotTattoo(slot))
            {
                t = ((int)slot).ToString() + t;
                m = ((int)slot).ToString() + m;
            }
            return MtaShared.AddPedClothes(element, t, m, (int)slot);
        }

        /// <summary>
        /// Add a clothes item from a slot and an index
        /// </summary>
        public bool AddClothes(ClothesSlot slot, int index)
        {
            Tuple<string, string> result = MtaShared.GetClothesByTypeIndex((int)slot, index);
            return MtaShared.AddPedClothes(element, result.Item1, result.Item2, (int)slot);
        }

        /// <summary>
        /// Add clothes from only texture and model (does not work on tattoos)
        /// </summary>
        public bool AddClothes(ClothesTexture texture, ClothesModel model)
        {
            Tuple<int, int> result = MtaShared.GetTypeIndexFromClothes(texture.ToString(), model.ToString());
            return AddClothes((ClothesSlot)result.Item1, result.Item2);
        }

        /// <summary>
        /// Get the current clothes model of a slot
        /// </summary>
        public ClothesModel GetClothesModel(ClothesSlot slot)
        {
            Tuple<string, string> result = MtaShared.GetPedClothes(element, (int)slot);
            return (ClothesModel)Enum.Parse(typeof(ClothesModel), result.Item2);
        }

        /// <summary>
        /// Get the current clothes texture of a slot
        /// </summary>
        public ClothesTexture GetClothesTexture(ClothesSlot slot)
        {
            Tuple<string, string> result = MtaShared.GetPedClothes(element, (int)slot);
            return (ClothesTexture)Enum.Parse(typeof(ClothesTexture), result.Item1);
        }

        /// <summary>
        /// Remove clothes from a certain slot
        /// </summary>
        public bool RemoveClothes(ClothesSlot slot)
        {
            return MtaShared.RemovePedClothes(element, (int)slot, null, null);
        }

        #endregion

        #region Weapon Methods

        /// <summary>
        /// Get the weapon in a specific slot
        /// </summary>
        public SharedWeaponModel GetWeaponInSlot(WeaponSlot slot)
        {
            return new SharedWeaponModel(MtaShared.GetPedWeapon(element, (int)slot));
        }

        /// <summary>
        /// This function returns an integer that contains the ammo a specific weaponslot
        /// </summary>
        public int GetAmmoInClip(WeaponSlot slot)
        {
            return MtaShared.GetPedAmmoInClip(element, (int)slot);
        }

        /// <summary>
        /// This function return the total ammo of a specific weaponslot
        /// </summary>
        public int GetTotalAmmo(WeaponSlot slot)
        {
            return MtaShared.GetPedTotalAmmo(element, (int)slot);
        }

        #endregion

        #region Animation Methods

        /// <summary>
        /// Sets the animation of this ped
        /// </summary>
        public bool SetAnimation(Animation animation, bool loop = true, int time = -1, bool updatePosition = true, bool interruptable = true, bool freeLastFrame = true, int blendTime = 250)
        {
            return MtaShared.SetPedAnimation(element, animation.Group, animation.Anim, time, loop, updatePosition, interruptable, freeLastFrame, blendTime);
        }

        /// <summary>
        /// Resets the animation back to normal
        /// </summary>
        public bool ResetAnimation()
        {
            return MtaShared.SetPedAnimation(element, null, null, -1, true, true, true, true, 250);
        }

        /// <summary>
        /// Sets the current animation progress of a player or ped.
        /// </summary>
        public bool SetAnimationProgress(Animation animation, float progress)
        {
            return MtaShared.SetPedAnimationProgress(element, animation.Anim, progress);
        }

        /// <summary>
        /// Sets the current animation speed of a player or ped.
        /// </summary>
        public bool SetAnimationSpeed(Animation animation, float speed = 1.0f)
        {
            return MtaShared.SetPedAnimationSpeed(element, animation.Anim, speed);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get the value of a specific stat
        /// </summary>
        public float GedStat(PedStat stat)
        {
            return MtaShared.GetPedStat(element, (int)stat);
        }

        /// <summary>
        /// Set a specific stat on this ped
        /// </summary>
        public bool SetStat(PedStat stat, float value)
        {
            return MtaShared.SetPedStat(element, (int)stat, value);
        }

        /// <summary>
        /// Kill the ped with a killer, a weapon and a bodypart
        /// </summary>
        public bool Kill(SharedPed killer, SharedWeaponModel weapon, BodyPart bodyPart, bool stealth = false)
        {
            return MtaShared.KillPed(element, killer.MTAElement, weapon.ID, (int)bodyPart, stealth);
        }

        /// <summary>
        /// Kill the ped, just providing a killer
        /// </summary>
        public bool Kill(SharedPed killer)
        {
            return MtaShared.KillPed(element, killer.MTAElement, 255, 255, false);
        }

        /// <summary>
        /// Kill the ped without a killer
        /// </summary>
        public bool Kill()
        {
            return MtaShared.KillPed(element, null, 255, 255, false);
        }

        /// <summary>
        /// Ejects the ped from a vehicle
        /// </summary>
        public bool RemoveFromVehicle()
        {
            return MtaShared.RemovePedFromVehicle(element);
        }

        /// <summary>
        /// Warp this ped into a vehicle, specifying a seat
        /// </summary>
        public bool WarpIntoVehicle(SharedVehicle vehicle, Seat seat)
        {
            return MtaShared.WarpPedIntoVehicle(element, vehicle.MTAElement, (int)seat);
        }

        /// <summary>
        /// Warp this ped into the driver seat of a vehicle
        /// </summary>
        public bool WarpIntoVehicle(SharedVehicle vehicle)
        {
            return MtaShared.WarpPedIntoVehicle(element, vehicle.MTAElement, 0);
        }

        #endregion

    }
}
