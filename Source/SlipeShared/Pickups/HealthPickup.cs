using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;
using Slipe.Shared.Enums;

namespace Slipe.Shared.Pickups
{
    public class HealthPickup : VitalPickup
    {
        public HealthPickup(MTAElement element) : base(element) { }

        public HealthPickup(Vector3 position, int amount = 100, int respawnTime = 30000) : base(position, PickupTypeEnum.HEALTH, amount, respawnTime) { }

    }
}
