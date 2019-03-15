using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared;
using Slipe.Shared.Enums;
using Slipe.MTADefinitions;
using System.Numerics;

namespace Slipe.Server
{
    public class Pickup : SharedPickup
    {
        public Pickup(MTAElement element) : base(element) { }

        public Pickup(Vector3 position, PickupTypeEnum type, int amount, int respawnTime = 30000, int ammo = 50) : base(position, type, amount, respawnTime, ammo) { }

        public Pickup(Vector3 position, WeaponEnum weapon, int ammo = 50, int respawnTime = 30000) : base(position, PickupTypeEnum.WEAPON, (int)weapon, respawnTime, ammo) { }

        public Pickup(Vector3 position, PickupModelEnum model, int respawnTime = 30000) : base(position, PickupTypeEnum.CUSTOM, (int)model, respawnTime) { }

        public Pickup(Vector3 position, int model) : base(position, PickupTypeEnum.CUSTOM, model) { }

        public int RespawnInterval
        {
            get
            {
                return MTAServer.GetPickupRespawnInterval(element);
            }
            set
            {
                MTAServer.SetPickupRespawnInterval(element, value);
            }
        }

        public bool IsSpawned
        {
            get
            {
                return MTAServer.IsPickupSpawned(element);
            }
        }

        public bool Use(Player player)
        {
            return MTAShared.UsePickup(element, player.MTAElement);
        }
    }
}