using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using Slipe.Client.Peds;
using System.Numerics;

namespace Slipe.Client.Weapons
{
    /// <summary>
    /// Represents a custom projectile
    /// </summary>
    [DefaultElementClass(ElementType.Projectile)]
    public class Projectile : PhysicalElement
    {
        #region Properties

        /// <summary>
        /// Get and set the time left before detonation
        /// </summary>
        public int Counter
        {
            get
            {
                return MtaClient.GetProjectileCounter(element);
            }
            set
            {
                MtaClient.SetProjectileCounter(element, value);
            }
        }

        /// <summary>
        /// Get the creator of this projectile
        /// </summary>
        public Player Creator
        {
            get
            {
                try
                {
                    return ElementManager.Instance.GetElement<Player>(MtaClient.GetProjectileCreator(element));
                } catch(MtaException)
                {
                    return null;
                }
                
            }
        }

        /// <summary>
        /// Get the target of this projectile
        /// </summary>
        public PhysicalElement Target
        {
            get
            {
                try
                {
                    return ElementManager.Instance.GetElement<PhysicalElement>(MtaClient.GetProjectileTarget(element));
                }
                catch (MtaException)
                {
                    return null;
                }

            }
        }

        /// <summary>
        /// Get the force this projectile has
        /// </summary>
        public float Force
        {
            get
            {
                return MtaClient.GetProjectileForce(element);
            }
        }

        /// <summary>
        /// Get the type of this projectile
        /// </summary>
        public ProjectileType ProjectileType
        {
            get
            {
                return (ProjectileType)MtaClient.GetProjectileType(element);
            }
        }

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Projectile(MtaElement element) : base(element) { }

        /// <summary>
        /// Create a new projectile with all the parameters
        /// </summary>
        public Projectile(PhysicalElement creator, ProjectileType projectile, Vector3 startPos, float force, PhysicalElement target, Vector3 rotation, Vector3 velocity, int model = -1)
            : this(MtaClient.CreateProjectile(creator.MTAElement, (int)projectile, startPos.X, startPos.Y, startPos.Z, force, target.MTAElement, rotation.X, rotation.Y, rotation.Z, velocity.X, velocity.Y, velocity.Z, -1)) { }

        /// <summary>
        /// Create a new projectile
        /// </summary>
        public Projectile(PhysicalElement creator, ProjectileType projectile, Vector3 startPos, float force, PhysicalElement target, Vector3 rotation) 
            : this(creator, projectile, startPos, force, target, rotation, Vector3.Zero) { }

        /// <summary>
        /// Create a new projectile
        /// </summary>
        public Projectile(PhysicalElement creator, ProjectileType projectile, Vector3 startPos, float force, PhysicalElement target) 
            : this(creator, projectile, startPos, force, target, Vector3.Zero) { }

        /// <summary>
        /// Create a new projectile
        /// </summary>
        public Projectile(PhysicalElement creator, ProjectileType projectile, Vector3 startPos, float force = 1.0f) 
            : this(creator, projectile, startPos, force, null) { }

        #endregion

        #region Events

        #pragma warning disable 67

        public delegate void OnCreatedHandler(PhysicalElement creator);
        public event OnCreatedHandler OnCreated;

        #pragma warning restore 67

        #endregion

    }
}
