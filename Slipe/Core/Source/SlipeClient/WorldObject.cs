using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.Shared.World;
using System.ComponentModel;

namespace Slipe.Client
{
    /// <summary>
    /// Class representing an object in the GTA world
    /// </summary>
    public class WorldObject : SharedWorldObject
    {

        /// <summary>
        /// Get the mass of this world object
        /// </summary>
        public float Mass
        {
            get
            {
                return MTAClient.GetObjectMass(element);
            }
            set
            {
                MTAClient.SetObjectMass(element, value);
            }
        }

        /// <summary>
        /// Get and set if this object should be breakable
        /// </summary>
        public bool Breakable
        {
            get
            {
                return MTAClient.IsObjectBreakable(element);
            }
            set
            {
                MTAClient.SetObjectBreakable(element, value);
            }
        }

        /// <summary>
        /// Set if this object should respawn
        /// </summary>
        public bool Respawns
        {
            set
            {
                MTAClient.ToggleObjectRespawn(element, value);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public WorldObject(MTAElement element): base(element)
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

        /// <summary>
        /// Break this object
        /// </summary>
        public void Break()
        {
            MTAClient.BreakObject(element);
        }

        /// <summary>
        /// Respawn this object
        /// </summary>
        public void Respawn()
        {
            MTAClient.RespawnObject(element);
        }
    }
}
