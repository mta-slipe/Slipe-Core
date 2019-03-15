using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared;
using Slipe.Shared.Enums;
using Slipe.MTADefinitions;
using System.Numerics;

namespace Slipe.Client
{
    public class Pickup : SharedPickup
    {
        public Pickup(MTAElement element) : base(element) { }

        public Pickup(Vector3 position, PickupTypeEnum type, int amount, int ammo = 50) : base (position, type, amount, 0, ammo) { }

        public Pickup(Vector3 position, WeaponEnum weapon, int ammo = 50) : base (position, PickupTypeEnum.WEAPON, (int)weapon, 0, ammo) { }

        public Pickup(Vector3 position, PickupModelEnum model) : base (position, PickupTypeEnum.CUSTOM, (int) model) { }

        public Pickup(Vector3 position, int model) : base (position, PickupTypeEnum.CUSTOM, model) { }
    }
}
