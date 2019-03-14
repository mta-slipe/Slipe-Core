using System;
using System.Collections.Generic;
using System.Text;
using MultiTheftAuto;
using System.Numerics;
using MTASharedWrapper.Enums;

namespace MTASharedWrapper.Pickups
{
    public class WeaponPickup : Pickup
    {
        public WeaponPickup(MTAElement element) : base(element) { }

        public WeaponPickup(Vector3 position, WeaponEnum weapon, int ammo = 50, int respawnTime = 30000) : base(position, PickupTypeEnum.WEAPON, (int) weapon, respawnTime, ammo) { }

        public int Ammo
        {
            get
            {
                return Shared.GetPickupAmmo(element);
            }
        }

        public WeaponEnum Weapon
        {
            get
            {
                return (WeaponEnum) Shared.GetPickupWeapon(element);
            }
        }

    }
}
