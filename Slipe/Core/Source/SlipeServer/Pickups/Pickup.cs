using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Numerics;
using Slipe.Shared.Weapons;
using Slipe.Shared.Pickups;
using System.ComponentModel;
using Slipe.Server.Peds;

namespace Slipe.Server.Pickups
{
    /// <summary>
    /// Class for a GTA pickup
    /// </summary>
    public class Pickup : SharedPickup
    {
        /// <summary>
        /// Gets and sets the respawn interval
        /// </summary>
        public int RespawnInterval
        {
            get
            {
                return MtaServer.GetPickupRespawnInterval(element);
            }
            set
            {
                MtaServer.SetPickupRespawnInterval(element, value);
            }
        }

        /// <summary>
        /// Get if this pickup is currently spawned
        /// </summary>
        public bool IsSpawned
        {
            get
            {
                return MtaServer.IsPickupSpawned(element);
            }
        }

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Pickup(MtaElement element) : base(element) { }

        /// <summary>
        /// Creates a pickup from the base createPickup paramters
        /// </summary>
        public Pickup(Vector3 position, PickupType type, int amount, int respawnTime = 30000, int ammo = 50) : base(position, type, amount, respawnTime, ammo) { }

        /// <summary>
        /// Creates a weapon pickup
        /// </summary>
        public Pickup(Vector3 position, SharedWeaponModel weapon, int ammo = 50, int respawnTime = 30000) : base(position, PickupType.Weapon, weapon.ID, respawnTime, ammo) { }

        /// <summary>
        /// Creates a custom model pickup
        /// </summary>
        public Pickup(Vector3 position, PickupModel model, int respawnTime = 30000) : base(position, PickupType.Custom, (int)model, respawnTime) { }

        /// <summary>
        /// Creates a model pickup from any model ID
        /// </summary>
        public Pickup(Vector3 position, int model) : base(position, PickupType.Custom, model) { }

        #endregion

        /// <summary>
        /// Have a player use this pickup
        /// </summary>
        public bool Use(Player player)
        {
            return MtaShared.UsePickup(element, player.MTAElement);
        }
    }
}