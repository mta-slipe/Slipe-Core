using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Numerics;
using Slipe.Shared.Weapons;
using Slipe.Shared.Pickups;
using System.ComponentModel;
using Slipe.Server.Peds;
using Slipe.Shared.Elements;

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
        public Pickup(MtaElement element) : base(element)
        {
        }

        /// <summary>
        /// Creates a pickup from all CreatePickup variables
        /// </summary>
        public Pickup(Vector3 position, PickupType type, int amount, int respawnTime = 30000, int ammo = 50)
            : this(MtaShared.CreatePickup(position.X, position.Y, position.Z, (int)type, amount, respawnTime, ammo)) { }

        /// <summary>
        /// Creates a weapon pickup
        /// </summary>
        public Pickup(Vector3 position, SharedWeaponModel weapon, int ammo = 50, int respawnTime = 30000) 
            : this(position, PickupType.Weapon, weapon.ID, respawnTime, ammo) { }

        /// <summary>
        /// Creates a custom model pickup
        /// </summary>
        public Pickup(Vector3 position, PickupModel model, int respawnTime = 30000) 
            : this(position, PickupType.Custom, (int)model, respawnTime) { }

        /// <summary>
        /// Creates a model pickup from any model ID
        /// </summary>
        public Pickup(Vector3 position, int model) 
            : this(position, PickupType.Custom, model) { }

        #endregion

        /// <summary>
        /// Have a player use this pickup
        /// </summary>
        public bool Use(Player player)
        {
            return MtaShared.UsePickup(element, player.MTAElement);
        }

        #region Events

        #pragma warning disable 67

        public delegate void OnSpawnHandler();
        public event OnSpawnHandler OnSpawn;

        public delegate void OnUseHandler(Player usingPlayer);
        public event OnUseHandler OnUse;

        #pragma warning restore 67

        #endregion
    }
}