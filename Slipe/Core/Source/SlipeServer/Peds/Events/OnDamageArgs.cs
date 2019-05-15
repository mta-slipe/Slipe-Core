using Slipe.Shared.Peds;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnDamageArgs
    {
        /// <summary>
        /// The player who was the attacker.
        /// </summary>
        public Player Attacker { get; }

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

        internal OnDamageArgs(Player attacker, DamageType damageType, BodyPart bodyPart, float loss)
        {
            Attacker = attacker;
            DamageType = damageType;
            BodyPart = bodyPart;
            Loss = loss;
        }
    }
}
