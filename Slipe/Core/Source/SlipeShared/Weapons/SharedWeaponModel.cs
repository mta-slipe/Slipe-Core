using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;

namespace SlipeLua.Shared.Weapons
{
    /// <summary>
    /// Class representing a weapon model
    /// </summary>
    public class SharedWeaponModel
    {
        #region Properties

        /// <summary>
        /// Get the ID of this weapon model
        /// </summary>
        public int ID { get; }

        /// <summary>
        /// Get the name of this weapon model
        /// </summary>
        public string Name
        {
            get
            {
                return MtaShared.GetWeaponNameFromID(ID);
            }
        }

        /// <summary>
        /// Get the weapon slot of this weapon model
        /// </summary>
        public WeaponSlot Slot
        {
            get
            {
                return (WeaponSlot) MtaShared.GetSlotFromWeapon(ID);
            }
        }

        #endregion

        #region All Weapons

        public static SharedWeaponModel Fist { get { return new SharedWeaponModel(0); } }
        public static SharedWeaponModel Brassknuckle { get { return new SharedWeaponModel(1); } }
        public static SharedWeaponModel Golfclub { get { return new SharedWeaponModel(2); } }
        public static SharedWeaponModel Nightstick { get { return new SharedWeaponModel(3); } }
        public static SharedWeaponModel Knife { get { return new SharedWeaponModel(4); } }
        public static SharedWeaponModel Bat { get { return new SharedWeaponModel(5); } }
        public static SharedWeaponModel Shovel { get { return new SharedWeaponModel(6); } }
        public static SharedWeaponModel Poolstick { get { return new SharedWeaponModel(7); } }
        public static SharedWeaponModel Katana { get { return new SharedWeaponModel(8); } }
        public static SharedWeaponModel Chainsaw { get { return new SharedWeaponModel(9); } }
        public static SharedWeaponModel Dildo1 { get { return new SharedWeaponModel(10); } }
        public static SharedWeaponModel Dildo2 { get { return new SharedWeaponModel(11); } }
        public static SharedWeaponModel Vibrator { get { return new SharedWeaponModel(12); } }
        public static SharedWeaponModel Flower { get { return new SharedWeaponModel(14); } }
        public static SharedWeaponModel Cane { get { return new SharedWeaponModel(15); } }
        public static SharedWeaponModel Grenade { get { return new SharedWeaponModel(16); } }
        public static SharedWeaponModel Teargas { get { return new SharedWeaponModel(17); } }
        public static SharedWeaponModel Molotov { get { return new SharedWeaponModel(18); } }
        public static SharedWeaponModel Colt45 { get { return new SharedWeaponModel(22); } }
        public static SharedWeaponModel Silenced { get { return new SharedWeaponModel(23); } }
        public static SharedWeaponModel Deagle { get { return new SharedWeaponModel(24); } }
        public static SharedWeaponModel Shotgun { get { return new SharedWeaponModel(25); } }
        public static SharedWeaponModel Sawedoff { get { return new SharedWeaponModel(26); } }
        public static SharedWeaponModel CombatShotgun { get { return new SharedWeaponModel(27); } }
        public static SharedWeaponModel Uzi { get { return new SharedWeaponModel(28); } }
        public static SharedWeaponModel Mp5 { get { return new SharedWeaponModel(29); } }
        public static SharedWeaponModel Ak47 { get { return new SharedWeaponModel(30); } }
        public static SharedWeaponModel M4 { get { return new SharedWeaponModel(31); } }
        public static SharedWeaponModel Tec9 { get { return new SharedWeaponModel(32); } }
        public static SharedWeaponModel Rifle { get { return new SharedWeaponModel(33); } }
        public static SharedWeaponModel Sniper { get { return new SharedWeaponModel(34); } }
        public static SharedWeaponModel RocketLauncer { get { return new SharedWeaponModel(35); } }
        public static SharedWeaponModel RocketLauncherHs { get { return new SharedWeaponModel(36); } }
        public static SharedWeaponModel Flamethrower { get { return new SharedWeaponModel(37); } }
        public static SharedWeaponModel Minigun { get { return new SharedWeaponModel(38); } }
        public static SharedWeaponModel Satchel { get { return new SharedWeaponModel(39); } }
        public static SharedWeaponModel Bomb { get { return new SharedWeaponModel(40); } }
        public static SharedWeaponModel Spraycan { get { return new SharedWeaponModel(41); } }
        public static SharedWeaponModel FireExtinguisher { get { return new SharedWeaponModel(42); } }
        public static SharedWeaponModel Camera { get { return new SharedWeaponModel(43); } }
        public static SharedWeaponModel Nightvision { get { return new SharedWeaponModel(44); } }
        public static SharedWeaponModel Infrared { get { return new SharedWeaponModel(45); } }
        public static SharedWeaponModel Parachute { get { return new SharedWeaponModel(46); } }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a weaopn model from an ID
        /// </summary>
        public SharedWeaponModel(int id)
        {
            ID = id;
        }

        /// <summary>
        /// Get a weapon model from the weapon name
        /// </summary>
        public SharedWeaponModel(string name) : this(MtaShared.GetWeaponIDFromName(name)) { }

        #endregion

        #region Methods

        /// <summary>
        /// Get the value of an original property of this model
        /// </summary>
        public int GetOriginalProperty(WeaponSkill skill, WeaponProperty property)
        {
            return MtaShared.GetOriginalWeaponProperty(ID, skill.ToString().ToLower(), property.ToString().ToLower());
        }

        /// <summary>
        /// Get the value of the current property of this model
        /// </summary>
        public int GetProperty(WeaponSkill skill, WeaponProperty property)
        {
            return MtaShared.GetWeaponProperty(ID, skill.ToString().ToLower(), property.ToString().ToLower());
        }

        #endregion
    }
}
