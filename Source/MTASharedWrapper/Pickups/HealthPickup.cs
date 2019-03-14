using System;
using System.Collections.Generic;
using System.Text;
using MultiTheftAuto;
using System.Numerics;
using MTASharedWrapper.Enums;

namespace MTASharedWrapper.Pickups
{
    public class HealthPickup : VitalPickup
    {
        public HealthPickup(MTAElement element) : base(element) { }

        public HealthPickup(Vector3 position, int amount = 100, int respawnTime = 30000) : base(position, PickupTypeEnum.HEALTH, amount, respawnTime) { }

    }
}
