using SlipeLua.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.ComponentModel;
using SlipeLua.Shared.GameWorld;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Explosions;
using SlipeLua.Client.Elements.Events;
using SlipeLua.Client.GameWorld.Events;

namespace SlipeLua.Client.GameWorld
{
    /// <summary>
    /// Class representing an object in the GTA world
    /// </summary>
    [DefaultElementClass(ElementType.Object)]
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

        /// <summary>
        /// Get and set the turning mass of the object
        /// </summary>
        public float TurnMass
        {
            get
            {
                return MtaClient.GetObjectProperty(element, "turn_mass");
            }
            set
            {
                MtaClient.SetObjectProperty(element, "turn_mass", value);
            }
        }

        /// <summary>
        /// Get and set the accuracy of the object
        /// </summary>
        public float Accuracy
        {
            get
            {
                return MtaClient.GetObjectProperty(element, "accuracy");
            }
            set
            {
                MtaClient.SetObjectProperty(element, "accuracy", value);
            }
        }

        /// <summary>
        /// Get and set the air resistance of the object
        /// </summary>
        public float AirResistance
        {
            get
            {
                return MtaClient.GetObjectProperty(element, "air_resistance");
            }
            set
            {
                MtaClient.SetObjectProperty(element, "air_resistance", value);
            }
        }

        /// <summary>
        /// Get and set the elasticity of the object
        /// </summary>
        public float Elasticity
        {
            get
            {
                return MtaClient.GetObjectProperty(element, "elasticity");
            }
            set
            {
                MtaClient.SetObjectProperty(element, "elasticity", value);
            }
        }

        /// <summary>
        /// Get and set the buoyancy of the object
        /// </summary>
        public float Buoyancy
        {
            get
            {
                return MtaClient.GetObjectProperty(element, "buoyancy");
            }
            set
            {
                MtaClient.SetObjectProperty(element, "buoyancy", value);
            }
        }

        /// <summary>
        /// Get and set the center of mass of the object
        /// </summary>
        public Vector3 CenterOfMass
        {
            get
            {
                Tuple<float, float, float> r = MtaClient.GetObjectProperty(element, "center_of_mass");
                return new Vector3(r.Item1, r.Item2, r.Item3);
            }
            set
            {
                MtaClient.SetObjectProperty(element, "center_of_mass", new Tuple<float, float, float>(value.X, value.Y, value.Z));
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

        public delegate void OnBreakHandler(WorldObject source, OnBreakEventArgs eventArgs);
        public event OnBreakHandler OnBreak;

        public delegate void OnDamageHandler(WorldObject source, OnDamageEventArgs eventArgs);
        public event OnDamageHandler OnDamage;

        public delegate void OnExplosionHandler(WorldObject source, OnExplosionEventArgs eventArgs);
        public event OnExplosionHandler OnExplosion;

        #pragma warning restore 67

        #endregion
    }
}
