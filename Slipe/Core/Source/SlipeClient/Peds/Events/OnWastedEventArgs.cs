﻿using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Peds;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Peds.Events
{
    public class OnWastedEventArgs
    {
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

        internal OnWastedEventArgs(MtaElement killer, dynamic damageType, dynamic bodyPart, dynamic stealth)
        {
            Killer =  ElementManager.Instance.GetElement<PhysicalElement>(killer);
            DamageType = (DamageType) damageType;
            BodyPart = (BodyPart) bodyPart;
            IsStealthKill = (bool) stealth;
        }
    }
}
