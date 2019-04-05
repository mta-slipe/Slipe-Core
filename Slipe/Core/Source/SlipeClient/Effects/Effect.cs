using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using Slipe.Shared;
using System.Numerics;

namespace Slipe.Client.Effects
{
    /// <summary>
    /// Represents a positionable effect
    /// </summary>
    public class Effect : PhysicalElement
    {
        /// <summary>
        /// Get and set the density (0-2)
        /// </summary>
        public float Density
        {
            get
            {
                return MTAClient.GetEffectDensity(element);
            }
            set
            {
                MTAClient.SetEffectDensity(element, value);
            }
        }

        /// <summary>
        /// Get and set the speed of the effect
        /// </summary>
        public float Speed
        {
            get
            {
                return MTAClient.GetEffectSpeed(element);
            }
            set
            {
                MTAClient.SetEffectSpeed(element, value);
            }
        }

        /// <summary>
        /// Create an effect from an MTAElement
        /// </summary>
        public Effect(MTAElement element) : base(element) { }

        /// <summary>
        /// Create an effect of a type
        /// </summary>
        public Effect(EffectType type, Vector3 position, Vector3 rotation, float drawDistance = 0, bool enableSound = false)
        {
            element = MTAClient.CreateEffect(type.ToString(), position.X, position.Y, position.Z, rotation.X, rotation.Y, rotation.Z, drawDistance, enableSound);
            ElementManager.Instance.RegisterElement(this);
        }
    }
}
