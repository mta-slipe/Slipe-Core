using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;
using Slipe.Shared.Peds;
using System.ComponentModel;

namespace Slipe.Server
{
    /// <summary>
    /// Represents a pedestrian 
    /// </summary>
    public class Ped : SharedPed
    {
        public Ped() : base() { }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Ped(MTAElement element) : base(element) { }

        /// <summary>
        /// Create a new ped
        /// </summary>
        public Ped(PedModel model, Vector3 position, float rotation = 0.0f, bool synced = true)
        {
            element = MTAServer.CreatePed((int)model, position.X, position.Y, position.Z, rotation, synced);
        }

        /// <summary>
        /// Get and set the amount of armor of this ped
        /// </summary>
        public new float Armor
        {
            get
            {
                return MTAShared.GetPedArmor(element);
            }
            set
            {
                MTAServer.SetPedArmor(element, value);
            }
        }

        /// <summary>
        /// Get and set the fighting style of the ped
        /// </summary>
        public new FightingStyle FightingStyle
        {
            get
            {
                return (FightingStyle)MTAShared.GetPedFightingStyle(element);
            }
            set
            {
                MTAServer.SetPedFightingStyle(element, (int)value);
            }
        }

        /// <summary>
        /// This function returns the current gravity for this ped. The default gravity is 0.008.
        /// </summary>
        public float Gravity
        {
            get
            {
                return MTAServer.GetPedGravity(element);
            }
            set
            {
                MTAServer.SetPedGravity(element, value);
            }
        }

        /// <summary>
        /// Get and set if the ped is choking
        /// </summary>
        public new bool Chocking
        {
            get
            {
                return MTAShared.IsPedChoking(element);
            }
            set
            {
                MTAServer.SetPedChoking(element, value);
            }
        }

        /// <summary>
        /// Get and set if the ped has a jetpack
        /// </summary>
        public new bool HasJetpack
        {
            get
            {
                return MTAShared.IsPedWearingJetpack(element);
            }
            set
            {
                MTAServer.SetPedWearingJetpack(element, value);
            }
        }

        /// <summary>
        /// This function reloads the weapon of this ped
        /// </summary>
        public bool ReloadWeapon()
        {
            return MTAServer.ReloadPedWeapon(element);
        }
    }

}
