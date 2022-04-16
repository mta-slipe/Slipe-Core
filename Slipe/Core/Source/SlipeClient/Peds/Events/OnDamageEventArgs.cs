using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Peds;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Peds.Events
{
    public class OnDamageEventArgs
    {
        /// <summary>
        /// The element who was the attacker.
        /// </summary>
        public PhysicalElement Attacker { get; }

        /// <summary>
        /// The attacker weapon or the damage type.
        /// </summary>
        public DamageType DamageType { get; }

        /// <summary>
        /// The bodypart the player was hit on when he got damaged.
        /// </summary>
        public BodyPart BodyPart { get; }

        /// <summary>
        /// The percentage of health the player lost.
        /// </summary>
        public float Loss { get; }

        internal OnDamageEventArgs(MtaElement attacker, dynamic damageType, dynamic bodyPart, dynamic loss)
        {
            Attacker = ElementManager.Instance.GetElement<PhysicalElement>(attacker);
            DamageType = (DamageType) damageType;
            BodyPart = (BodyPart) bodyPart;
            Loss = (float) loss;
        }
    }
}
