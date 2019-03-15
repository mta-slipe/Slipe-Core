using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;
using Slipe.Shared.Enums;

namespace Slipe.Shared.Pickups
{
    public class CustomPickup : Pickup
    {
        public CustomPickup(MTAElement element) : base(element) { }

        public CustomPickup(Vector3 position, PickupModelEnum model, int respawnTime = 30000) : base(position, PickupTypeEnum.CUSTOM, (int) model, respawnTime) { }

        public CustomPickup(Vector3 position, int model) : base(position, PickupTypeEnum.CUSTOM, model) { }

    }
}
