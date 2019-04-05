using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;
using Slipe.Shared.Weapons;
using Slipe.Shared.Pickups;

namespace Slipe.Server
{
    /// <summary>
    /// Class for a GTA pickup
    /// </summary>
    public class Pickup : SharedPickup
    {
        /// <summary>
        /// Creates or retrieves a pickup from an MTA pickup element
        /// </summary>
        public Pickup(MTAElement element) : base(element) { }

        /// <summary>
        /// Creates a pickup from the base createPickup paramters
        /// </summary>
        public Pickup(Vector3 position, PickupType type, int amount, int respawnTime = 30000, int ammo = 50) : base(position, type, amount, respawnTime, ammo) { }

        /// <summary>
        /// Creates a weapon pickup
        /// </summary>
        public Pickup(Vector3 position, WeaponType weapon, int ammo = 50, int respawnTime = 30000) : base(position, PickupType.Weapon, (int)weapon, respawnTime, ammo) { }

        /// <summary>
        /// Creates a custom model pickup
        /// </summary>
        public Pickup(Vector3 position, PickupModel model, int respawnTime = 30000) : base(position, PickupType.Custom, (int)model, respawnTime) { }

        /// <summary>
        /// Creates a model pickup from any model ID
        /// </summary>
        public Pickup(Vector3 position, int model) : base(position, PickupType.Custom, model) { }

        /// <summary>
        /// Gets and sets the respawn interval
        /// </summary>
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

        /// <summary>
        /// Get if this pickup is currently spawned
        /// </summary>
        public bool IsSpawned
        {
            get
            {
                return MTAServer.IsPickupSpawned(element);
            }
        }

        /// <summary>
        /// Have a player use this pickup
        /// </summary>
        public bool Use(Player player)
        {
            return MTAShared.UsePickup(element, player.MTAElement);
        }
    }
}