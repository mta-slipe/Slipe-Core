using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared;
using Slipe.MTADefinitions;
using Slipe.Shared.Enums;

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
        public bool SetJetPackWeaponEnabled(WeaponEnum weapon, bool enabled)
        {
            return MTAServer.SetJetpackWeaponEnabled(EnumTranslator.Instance.TranslateWeapon(weapon), enabled);
        }

        /// <summary>
        /// Check if a certain weapon is enabled on the jetpack
        /// </summary>
        public bool getJetPackWeaponEnabled(WeaponEnum weapon)
        {
            return MTAServer.GetJetpackWeaponEnabled(EnumTranslator.Instance.TranslateWeapon(weapon));
        }

        /// <summary>
        /// Get a specific garage class instance from a garage ID
        /// </summary>
        public new Garage GetGarage(GarageEnum garage)
        {
            return new Garage(garage);
        }

    }
}
