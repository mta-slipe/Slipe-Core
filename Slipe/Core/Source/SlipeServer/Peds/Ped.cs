using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MtaDefinitions;
using Slipe.Shared.Peds;
using System.ComponentModel;

namespace Slipe.Server.Peds
{
    /// <summary>
    /// Represents a pedestrian 
    /// </summary>
    public class Ped : SharedPed
    {
        #region Properties

        /// <summary>
        /// Get and set the amount of armor of this ped
        /// </summary>
        public new float Armor
        {
            get
            {
                return MtaShared.GetPedArmor(element);
            }
            set
            {
                MtaServer.SetPedArmor(element, value);
            }
        }

        /// <summary>
        /// Get and set the fighting style of the ped
        /// </summary>
        public new FightingStyle FightingStyle
        {
            get
            {
                return (FightingStyle)MtaShared.GetPedFightingStyle(element);
            }
            set
            {
                MtaServer.SetPedFightingStyle(element, (int)value);
            }
        }

        /// <summary>
        /// This function returns the current gravity for this ped. The default gravity is 0.008.
        /// </summary>
        public float Gravity
        {
            get
            {
                return MtaServer.GetPedGravity(element);
            }
            set
            {
                MtaServer.SetPedGravity(element, value);
            }
        }

        /// <summary>
        /// Get and set if the ped is choking
        /// </summary>
        public new bool Chocking
        {
            get
            {
                return MtaShared.IsPedChoking(element);
            }
            set
            {
                MtaServer.SetPedChoking(element, value);
            }
        }

        /// <summary>
        /// Get and set if the ped has a jetpack
        /// </summary>
        public new bool HasJetpack
        {
            get
            {
                return MtaShared.IsPedWearingJetpack(element);
            }
            set
            {
                MtaServer.SetPedWearingJetpack(element, value);
            }
        }

        #endregion 

        #region Constructors

        public Ped() : base() { }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Ped(MtaElement element) : base(element) { }

        /// <summary>
        /// Create a new ped
        /// </summary>
        public Ped(PedModel model, Vector3 position, float rotation = 0.0f, bool synced = true)
        {
            element = MtaServer.CreatePed((int)model, position.X, position.Y, position.Z, rotation, synced);
        }

        #endregion

        /// <summary>
        /// This function reloads the weapon of this ped
        /// </summary>
        public bool ReloadWeapon()
        {
            return MtaServer.ReloadPedWeapon(element);
        }
    }

}
