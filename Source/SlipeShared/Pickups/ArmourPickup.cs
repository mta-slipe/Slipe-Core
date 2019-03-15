using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;
using Slipe.Shared.Enums;

namespace Slipe.Shared.Pickups
{
    public class ArmourPickup : VitalPickup
    {
        public ArmourPickup(MTAElement element) : base(element) { }

        public ArmourPickup(Vector3 position, int amount = 100, int respawnTime = 30000) : base (position, PickupTypeEnum.ARMOUR, amount, respawnTime) { }

    }
}
