using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.Shared.Enums;
using Slipe.MTADefinitions;


namespace Slipe.Shared
{
    public class SharedPickup : PhysicalElement
    {
        public SharedPickup(MTAElement element) : base(element) { }

        public SharedPickup(Vector3 position, PickupTypeEnum type, int amount, int respawnTime = 30000, int ammo = 50)
        {
            element = MTAShared.CreatePickup(position.X, position.Y, position.Z, (int) type, amount, respawnTime, ammo);
            ElementManager.Instance.RegisterElement(this);
        }

        public SharedPickup(Vector3 position, WeaponEnum weapon, int ammo = 50, int respawnTime = 30000) : this(position, PickupTypeEnum.WEAPON, (int) weapon, respawnTime, ammo) { }

        public SharedPickup(Vector3 position, PickupModelEnum model, int respawnTime = 30000) : this(position, PickupTypeEnum.CUSTOM, (int )model, respawnTime) { }

        public SharedPickup(Vector3 position, int model) : this(position, PickupTypeEnum.CUSTOM, model) { }

        public PickupTypeEnum PickupType
        {
            get
            {
                return (PickupTypeEnum) MTAShared.GetPickupType(element);
            }
        }

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
                return (WeaponEnum)MTAShared.GetPickupWeapon(element);
            }
        }

        public int Amount
        {
            get
            {
                return MTAShared.GetPickupAmount(element);
            }
        }

        public bool Morph(PickupTypeEnum type, int amount, int ammo = 50)
        {
            return MTAShared.SetPickupType(element, (int)type, amount, ammo);
        }

        public bool Morph(WeaponEnum weapon, int ammo = 50)
        {
            return Morph(PickupTypeEnum.WEAPON, (int)weapon, ammo);
        }

        public bool Morph(PickupModelEnum model)
        {
            return Morph(PickupTypeEnum.CUSTOM, (int)model);
        }

        public bool Morph(int model)
        {
            return Morph(PickupTypeEnum.CUSTOM, model);
        }

    }
}
