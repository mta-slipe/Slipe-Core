using Slipe.Shared.Elements;
using Slipe.Shared.Peds;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnWastedArgs
    {
        /// <summary>
        /// The total ammo the victim had when he died.
        /// </summary>
        public int RemainingAmmo { get; }

        /// <summary>
        /// The player or vehicle who was the killer. If there was no killer this is null.
        /// </summary>
        public PhysicalElement Killer { get; }

        /// <summary>
        /// The killer weapon or the damage types.
        /// </summary>
        public DamageType DamageType { get; }

        /// <summary>
        /// The bodypart ID the victim was hit on when he died.
        /// </summary>
        public BodyPart BodyPart { get; }

        /// <summary>
        /// Whether or not this was a stealth kill.
        /// </summary>
        public bool IsStealthKill { get; }

        internal OnWastedArgs(int remainingAmmo, PhysicalElement killer, DamageType damageType, BodyPart bodyPart, bool stealth)
        {
            RemainingAmmo = remainingAmmo;
            Killer = killer;
            DamageType = damageType;
            BodyPart = bodyPart;
            IsStealthKill = stealth;
        }
    }
}
