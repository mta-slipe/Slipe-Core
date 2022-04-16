using SlipeLua.Server.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Peds.Events
{
    public class OnWeaponSwitchEventArgs
    {
        /// <summary>
        /// The weapon switched from
        /// </summary>
        public WeaponModel PreviousWeapon { get; }

        /// <summary>
        /// The weapon switched to
        /// </summary>
        public WeaponModel NewWeapon { get; }

        internal OnWeaponSwitchEventArgs(dynamic previousWeapon, dynamic newWeapon)
        {
            PreviousWeapon = new WeaponModel((int)previousWeapon);
            NewWeapon = new WeaponModel((int)newWeapon);
        }
    }
}
