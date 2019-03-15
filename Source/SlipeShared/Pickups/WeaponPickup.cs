using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;
using Slipe.Shared.Enums;

namespace Slipe.Shared.Pickups
{
    public class WeaponPickup : Pickup
    {
        public WeaponPickup(MTAElement element) : base(element) { }

        public WeaponPickup(Vector3 position, WeaponEnum weapon, int ammo = 50, int respawnTime = 30000) : base(position, PickupTypeEnum.WEAPON, (int) weapon, respawnTime, ammo) { }

        public int Ammo
        {
            get
            {
                return MTAShared.GetPickupAmmo(element);
            }
        }

        public WeaponEnum Weapon
        {
            get
            {
                return (WeaponEnum) MTAShared.GetPickupWeapon(element);
            }
        }

    }
}
