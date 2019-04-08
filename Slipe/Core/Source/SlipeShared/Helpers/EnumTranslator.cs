using Slipe.Shared.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Helpers
{
    /// <summary>
    /// Provides helper methods to translate certain enums to strings or other objects
    /// </summary>
    public class EnumTranslator
    {
        private static EnumTranslator instance;

        /// <summary>
        /// Get the singleton instance of this class
        /// </summary>
        public static EnumTranslator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EnumTranslator();
                }
                return instance;
            }
        }

        public EnumTranslator()
        {
        }

        /// <summary>
        /// Translates a weapon enum to a lowercase name, useful for the jetpack functions
        /// </summary>
        public string TranslateWeapon(WeaponType weaponEnum)
        {
            switch (weaponEnum)
            {
                case WeaponType.Ak47:
                    return "ak-47";
                case WeaponType.Colt45:
                    return "colt 45";
                case WeaponType.Tec9:
                    return "tec-9";
                default:
                    return weaponEnum.ToString().ToLower();
            }

        }
    }
}
