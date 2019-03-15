using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;
using Slipe.Shared.Enums;

namespace Slipe.Shared.Pickups
{
    public class VitalPickup : Pickup
    {
        public VitalPickup(MTAElement element) : base(element) { }

        public VitalPickup(Vector3 position, PickupTypeEnum type, int amount = 100, int respawnTime = 30000) : base(position, type, amount, respawnTime) { }

        public int Amount
        {
            get
            {
                return MTAShared.GetPickupAmount(element);
            }
        }

    }

}
