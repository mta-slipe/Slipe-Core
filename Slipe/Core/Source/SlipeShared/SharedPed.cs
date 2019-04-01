using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;
using Slipe.Shared.Enums;
using Slipe.Shared.Structs;

namespace Slipe.Shared
{
    /// <summary>
    /// Represents a pedestrian with shared server/client functionality
    /// </summary>
    public class SharedPed : PhysicalElement
    {
        public SharedPed() : base() { }

        /// <summary>
        /// Create a ped from an empty element
        /// </summary>
        public SharedPed(MTAElement element) : base(element) { }

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
            if(IsClothesSlotTattoo(slot))
            {
                t = ((int)slot).ToString() + t;
                m = ((int)slot).ToString() + m;
            }
            return MTAShared.AddPedClothes(element, t, m, (int)slot);
        }

        /// <summary>
        /// Add a clothes item from a slot and an index
        /// </summary>
        public bool AddClothes(ClothesSlot slot, int index)
        {
            Tuple<string, string> result = MTAShared.GetClothesByTypeIndex((int)slot, index);
            return MTAShared.AddPedClothes(element, result.Item1, result.Item2, (int)slot);
        }

        /// <summary>
        /// Add clothes from only texture and model (does not work on tattoos)
        /// </summary>
        public bool AddClothes(ClothesTexture texture, ClothesModel model)
        {
            Tuple<int, int> result = MTAShared.GetTypeIndexFromClothes(texture.ToString(), model.ToString());
            return AddClothes((ClothesSlot) result.Item1, result.Item2);
        }

        /// <summary>
        /// Get the current clothes model of a slot
        /// </summary>
        public ClothesModel GetClothesModel(ClothesSlot slot)
        {
            Tuple<string, string> result = MTAShared.GetPedClothes(element, (int)slot);
            return (ClothesModel)Enum.Parse(typeof(ClothesModel), result.Item2);
        }

        /// <summary>
        /// Get the current clothes texture of a slot
        /// </summary>
        public ClothesTexture GetClothesTexture(ClothesSlot slot)
        {
            Tuple<string, string> result = MTAShared.GetPedClothes(element, (int)slot);
            return (ClothesTexture)Enum.Parse(typeof(ClothesTexture), result.Item1);
        }

        /// <summary>
        /// Remove clothes from a certain slot
        /// </summary>
        public bool RemoveClothes(ClothesSlot slot)
        {
            return MTAShared.RemovePedClothes(element, (int)slot, null, null);
        }

        /// <summary>
        /// Get and set the current weaponslot of the ped
        /// </summary>
        public WeaponSlot WeaponSlot
        {
            get
            {
                return (WeaponSlot) MTAShared.GetPedWeaponSlot(element);
            }
            set
            {
                MTAShared.SetPedWeaponSlot(element, (int)value);
            }
        }

        /// <summary>
        /// Get the amount of armor of this ped
        /// </summary>
        public float Armor
        {
            get
            {
                return MTAShared.GetPedArmor(element);
            }
        }

        /// <summary>
        /// This function detects the element a ped is standing on.
        /// </summary>
        public PhysicalElement ContactElement
        {
            get
            {
                return (PhysicalElement) ElementManager.Instance.GetElement(MTAShared.GetPedContactElement(element));
            }
        }

        /// <summary>
        /// Get the fighting style of the ped
        /// </summary>
        public FightingStyle FightingStyle
        {
            get
            {
                return (FightingStyle)MTAShared.GetPedFightingStyle(element);
            }
        }

        /// <summary>
        /// This function gets the vehicle that the ped is currently in or is trying to enter, if any.
        /// </summary>
        public SharedVehicle OccupiedVehicle
        {
            get
            {
                return (SharedVehicle) ElementManager.Instance.GetElement(MTAShared.GetPedOccupiedVehicle(element));
            }
        }

        /// <summary>
        /// Get the seat the ped occupies
        /// </summary>
        public VehicleSeat VehicleSeat
        {
            get
            {
                return (VehicleSeat)MTAShared.GetPedOccupiedVehicleSeat(element);
            }
        }

        /// <summary>
        /// Get if the ped is choking
        /// </summary>
        public bool Chocking
        {
            get
            {
                return MTAShared.IsPedChoking(element);
            }
        }

        /// <summary>
        /// Check if the ped is dead
        /// </summary>
        public bool IsDead
        {
            get
            {
                return MTAShared.IsPedDead(element);
            }
        }

        /// <summary>
        /// Get and set if the ped is doing a gang driveby
        /// </summary>
        public bool DoingGangDriveby
        {
            get
            {
                return MTAShared.IsPedDoingGangDriveby(element);
            }
            set
            {
                MTAShared.SetPedDoingGangDriveby(element, value);
            }
        }

        /// <summary>
        /// Get if the ped is ducked (crouched)
        /// </summary>
        public bool IsDucked
        {
            get
            {
                return MTAShared.IsPedDucked(element);
            }
        }

        /// <summary>
        /// Get and set if the ped is headless
        /// </summary>
        public bool Headless
        {
            get
            {
                return MTAShared.IsPedHeadless(element);
            }
            set
            {
                MTAShared.SetPedHeadless(element, value);
            }
        }

        /// <summary>
        /// Get if the ped is in a vehicle
        /// </summary>
        public bool IsInVehicle
        {
            get
            {
                return MTAShared.IsPedInVehicle(element);
            }
        }

        /// <summary>
        /// Get and set if the ped is on fire
        /// </summary>
        public bool OnFire
        {
            get
            {
                return MTAShared.IsPedOnFire(element);
            }
            set
            {
                MTAShared.SetPedOnFire(element, value);
            }
        }

        /// <summary>
        /// Get if the ped is standing on the ground
        /// </summary>
        public bool IsOnGround
        {
            get
            {
                return MTAShared.IsPedOnGround(element);
            }
        }

        /// <summary>
        /// Get if the ped has a jetpack
        /// </summary>
        public bool Jetpack
        {
            get
            {
                return MTAShared.IsPedWearingJetpack(element);
            }
        }

        /// <summary>
        /// Get the value of a specific stat
        /// </summary>
        public float GedStat(PedStat stat)
        {
            return MTAShared.GetPedStat(element, (int)stat);
        }

        /// <summary>
        /// Set a specific stat on this ped
        /// </summary>
        public bool SetStat(PedStat stat, float value)
        {
            return MTAShared.SetPedStat(element, (int)stat, value);
        }

        /// <summary>
        /// Get the element this ped is currently targeting
        /// </summary>
        public PhysicalElement Target
        {
            get
            {
                return (PhysicalElement)ElementManager.Instance.GetElement(MTAShared.GetPedTarget(element));
            }
        }

        /// <summary>
        /// Get and set the walking style of this ped
        /// </summary>
        public WalkingStyle WalkingStyle
        {
            get
            {
                return (WalkingStyle)MTAShared.GetPedWalkingStyle(element);
            }
            set
            {
                MTAShared.SetPedWalkingStyle(element, (int)value);
            }
        }

        /// <summary>
        /// Get the current weapon
        /// </summary>
        public WeaponEnum Weapon
        {
            get
            {
                return (WeaponEnum) MTAShared.GetPedWeapon(element, (int)WeaponSlot);
            }
        }

        /// <summary>
        /// Get the weapon in a specific slot
        /// </summary>
        public WeaponEnum GetWeaponInSlot(WeaponSlot slot)
        {
            return (WeaponEnum)MTAShared.GetPedWeapon(element, (int)slot);
        }

        /// <summary>
        /// This function returns an integer that contains the ammo a specific weaponslot
        /// </summary>
        public int GetAmmoInClip(WeaponSlot slot)
        {
            return MTAShared.GetPedAmmoInClip(element, (int)slot);
        }

        /// <summary>
        /// This function returns an integer that contains the ammo of the current weapon
        /// </summary>
        /// <returns></returns>
        public int GetAmmoInClip()
        {
            return MTAShared.GetPedAmmoInClip(element, (int)WeaponSlot);
        }

        /// <summary>
        /// This function return the total ammo of a specific weaponslot
        /// </summary>
        public int GetTotalAmmo(WeaponSlot slot)
        {
            return MTAShared.GetPedTotalAmmo(element, (int)slot);
        }

        /// <summary>
        /// This function returns the total ammo in the current weaponslot
        /// </summary>
        public int GetTotalAmmo()
        {
            return MTAShared.GetPedTotalAmmo(element, (int)WeaponSlot);
        }

        /// <summary>
        /// Kill the ped with a killer, a weapon and a bodypart
        /// </summary>
        public bool Kill(SharedPed killer, WeaponEnum weapon, BodyPart bodyPart, bool stealth = false)
        {
            return MTAShared.KillPed(element, killer.MTAElement, (int)weapon, (int)bodyPart, stealth);
        }

        /// <summary>
        /// Kill the ped, just providing a killer
        /// </summary>
        public bool Kill(SharedPed killer)
        {
            return MTAShared.KillPed(element, killer.MTAElement, 255, 255, false);
        }

        /// <summary>
        /// Kill the ped without a killer
        /// </summary>
        /// <returns></returns>
        public bool Kill()
        {
            return MTAShared.KillPed(element, null, 255, 255, false);
        }

        /// <summary>
        /// Ejects the ped from a vehicle
        /// </summary>
        public bool RemoveFromVehicle()
        {
            return MTAShared.RemovePedFromVehicle(element);
        }

        /// <summary>
        /// Warp this ped into a vehicle, specifying a seat
        /// </summary>
        public bool WarpIntoVehicle(SharedVehicle vehicle, VehicleSeat seat)
        {
            return MTAShared.WarpPedIntoVehicle(element, vehicle.MTAElement, (int)seat);
        }

        /// <summary>
        /// Warp this ped into the driver seat of a vehicle
        /// </summary>
        public bool WarpIntoVehicle(SharedVehicle vehicle)
        {
            return MTAShared.WarpPedIntoVehicle(element, vehicle.MTAElement, 0);
        }

        /// <summary>
        /// Sets the animation of this ped
        /// </summary>
        public bool SetAnimation(Animation animation, int time = -1, bool loop = true, bool updatePosition = true, bool interruptable = true, bool freeLastFrame = true, int blendTime = 250)
        {
            return MTAShared.SetPedAnimation(element, animation.Group, animation.Anim, time, loop, updatePosition, interruptable, freeLastFrame, blendTime);
        }

        /// <summary>
        /// Resets the animation back to normal
        /// </summary>
        public bool ResetAnimation()
        {
            return MTAShared.SetPedAnimation(element, null, null, -1, true, true, true, true, 250);
        }

        /// <summary>
        /// Sets the current animation progress of a player or ped.
        /// </summary>
        public bool SetAnimationProgress(Animation animation, float progress)
        {
            return MTAShared.SetPedAnimationProgress(element, animation.Anim, progress);
        }

        /// <summary>
        /// Sets the current animation speed of a player or ped.
        /// </summary>
        public bool SetAnimationSpeed(Animation animation, float speed = 1.0f)
        {
            return MTAShared.SetPedAnimationSpeed(element, animation.Anim, speed);
        }

    }
}
