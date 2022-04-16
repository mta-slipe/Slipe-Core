using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;
using System.Numerics;
using System.ComponentModel;
using SlipeLua.Shared.Elements;

namespace SlipeLua.Client.Effects
{
    /// <summary>
    /// Represents a positionable effect
    /// </summary>
    [DefaultElementClass(ElementType.Effect)]
    public class Effect : PhysicalElement
    {
        /// <summary>
        /// Get and set the density (0-2)
        /// </summary>
        public float Density
        {
            get
            {
                return MtaClient.GetEffectDensity(element);
            }
            set
            {
                MtaClient.SetEffectDensity(element, value);
            }
        }

        /// <summary>
        /// Get and set the speed of the effect
        /// </summary>
        public float Speed
        {
            get
            {
                return MtaClient.GetEffectSpeed(element);
            }
            set
            {
                MtaClient.SetEffectSpeed(element, value);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Effect(MtaElement element) : base(element) { }

        /// <summary>
        /// Create an effect of a type
        /// </summary>
        public Effect(EffectType type, Vector3 position, Vector3 rotation, float drawDistance = 0, bool enableSound = false)
            :base(MtaClient.CreateEffect(type.ToString(), position.X, position.Y, position.Z, rotation.X, rotation.Y, rotation.Z, drawDistance, enableSound)) { }
    }
}
