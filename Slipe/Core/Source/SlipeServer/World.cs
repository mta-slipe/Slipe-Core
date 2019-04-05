using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared;
using Slipe.MTADefinitions;
using Slipe.Shared.Enums;
using Slipe.Shared.World;
using Slipe.Shared.Weapons;

namespace Slipe.Server
{
    public class World : SharedWorld
    {
        public static new World Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new World();
                }
                return (World) instance;
            }
        }

        /// <summary>
        /// Instantiate a new world
        /// </summary>
        public World()
        {

        }

        /// <summary>
        /// Enable or disable the use of a weapon on a jetpack
        /// </summary>
        public bool SetJetPackWeaponEnabled(WeaponType weapon, bool enabled)
        {
            return MTAServer.SetJetpackWeaponEnabled(EnumTranslator.Instance.TranslateWeapon(weapon), enabled);
        }

        /// <summary>
        /// Check if a certain weapon is enabled on the jetpack
        /// </summary>
        public bool getJetPackWeaponEnabled(WeaponType weapon)
        {
            return MTAServer.GetJetpackWeaponEnabled(EnumTranslator.Instance.TranslateWeapon(weapon));
        }

        /// <summary>
        /// Get a specific garage class instance from a garage ID
        /// </summary>
        public new Garage GetGarage(GarageLocation garage)
        {
            return new Garage(garage);
        }

    }
}
