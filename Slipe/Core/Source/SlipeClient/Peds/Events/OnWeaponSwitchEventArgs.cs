using Slipe.Shared.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Peds.Events
{
    public class OnWeaponSwitchEventArgs
    {
        /// <summary>
        /// The weapon switched from
        /// </summary>
        public SharedWeaponModel PreviousWeapon { get; }

        /// <summary>
        /// The weapon switched to
        /// </summary>
        public SharedWeaponModel NewWeapon { get; }

        internal OnWeaponSwitchEventArgs(dynamic previousWeapon, dynamic newWeapon)
        {
            PreviousWeapon = new SharedWeaponModel((int)previousWeapon);
            NewWeapon = new SharedWeaponModel((int)newWeapon);
        }
    }
}
