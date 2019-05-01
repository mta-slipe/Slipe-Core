using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.ComponentModel;
using Slipe.Shared.GameWorld;
using Slipe.Shared.Elements;
using Slipe.Shared.Explosions;

namespace Slipe.Client.GameWorld
{
    /// <summary>
    /// Class representing an object in the GTA world
    /// </summary>
    [DefaultElementClass("object")]
    public class WorldObject : SharedWorldObject
    {
        #region Properties

        /// <summary>
        /// Get the mass of this world object
        /// </summary>
        public float Mass
        {
            get
            {
                return MtaClient.GetObjectMass(element);
            }
            set
            {
                MtaClient.SetObjectMass(element, value);
            }
        }

        /// <summary>
        /// Get and set if this object should be breakable
        /// </summary>
        public bool Breakable
        {
            get
            {
                return MtaClient.IsObjectBreakable(element);
            }
            set
            {
                MtaClient.SetObjectBreakable(element, value);
            }
        }

        /// <summary>
        /// Set if this object should respawn
        /// </summary>
        public bool Respawns
        {
            set
            {
                MtaClient.ToggleObjectRespawn(element, value);
            }
        }

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public WorldObject(MtaElement element) : base(element)
        {

        }

        /// <summary>
        /// Create a world object at a specific position
        /// </summary>
        public WorldObject(int model, Vector3 position) : base(model, position)
        {
        }

        /// <summary>
        /// Create a world object using all parameters
        /// </summary>
        public WorldObject(int model, Vector3 position, Vector3 rotation, bool isLowLOD = false) : base(model, position, rotation, isLowLOD)
        {
        }

        #endregion

        /// <summary>
        /// Break this object
        /// </summary>
        public void Break()
        {
            MtaClient.BreakObject(element);
        }

        /// <summary>
        /// Respawn this object
        /// </summary>
        public void Respawn()
        {
            MtaClient.RespawnObject(element);
        }

        #region Events

        #pragma warning disable 67

        public delegate void OnBreakHandler(PhysicalElement attacker);
        public event OnBreakHandler OnBreak;

        public delegate void OnDamageHandler(float loss, PhysicalElement attacker);
        public event OnDamageHandler OnDamage;

        public delegate void OnExplosionHandler(Vector3 position, ExplosionType type);
        public event OnExplosionHandler OnExplosion;

        #pragma warning restore 67

        #endregion
    }
}
