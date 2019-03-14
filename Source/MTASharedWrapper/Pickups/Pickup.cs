using System;
using System.Collections.Generic;
using System.Text;
using MultiTheftAuto;
using System.Numerics;
using MTASharedWrapper.Enums;

namespace MTASharedWrapper.Pickups
{
    public class Pickup : PhysicalElement
    {
        public Pickup(MTAElement element) : base (element) { }

        public Pickup(Vector3 position, PickupTypeEnum type, int amount, int respawnTime = 30000, int ammo = 50)
        {
            element = Shared.CreatePickup(position.X, position.Y, position.Z, (int)type, amount, respawnTime, ammo);
            ElementManager.Instance.RegisterElement(this);
        }

        public PickupTypeEnum Type
        {
            get
            {
                return (PickupTypeEnum) Shared.GetPickupType(element);
            }
        }

        public bool Use(SharedPlayer player)
        {
            return Shared.UsePickup(element, player.MTAElement);
        }
    }
}
