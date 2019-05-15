using Slipe.Server.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnWeaponSwitchArgs
    {
        /// <summary>
        /// The weapon switched from
        /// </summary>
        public WeaponModel PreviousWeapon { get; }

        /// <summary>
        /// The weapon switched to
        /// </summary>
        public WeaponModel NewWeapon { get; }

        internal OnWeaponSwitchArgs(WeaponModel previousWeapon, WeaponModel newWeapon)
        {
            PreviousWeapon = previousWeapon;
            NewWeapon = newWeapon;
        }
    }
}
