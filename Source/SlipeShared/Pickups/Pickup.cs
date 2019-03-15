using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;
using Slipe.Shared.Enums;

namespace Slipe.Shared.Pickups
{
    public class Pickup : PhysicalElement
    {
        public Pickup(MTAElement element) : base (element) { }

        public Pickup(Vector3 position, PickupTypeEnum type, int amount, int respawnTime = 30000, int ammo = 50)
        {
            element = MTAShared.CreatePickup(position.X, position.Y, position.Z, (int)type, amount, respawnTime, ammo);
            ElementManager.Instance.RegisterElement(this);
        }

        public PickupTypeEnum Type
        {
            get
            {
                return (PickupTypeEnum) MTAShared.GetPickupType(element);
            }
        }

        public bool Use(SharedPlayer player)
        {
            return MTAShared.UsePickup(element, player.MTAElement);
        }
    }
}
