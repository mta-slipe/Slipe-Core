using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Weapons;
using Slipe.MtaDefinitions;

namespace Slipe.Server.Weapons
{
    public class WeaponModel : SharedWeaponModel
    {
        #region Properties

        /// <summary>
        /// Get and set if this weapon is enabled on jetpacks
        /// </summary>
        public bool JetPackEnabled
        {
            get
            {
                return MtaServer.GetJetpackWeaponEnabled(Name);
            }
            set
            {
                MtaServer.SetJetpackWeaponEnabled(Name, value);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Get a weapon model from the weapon name
        /// </summary>
        public WeaponModel(string name) : base(name) { }

        /// <summary>
        /// Get a weapon model from the weapon id
        /// </summary>
        public WeaponModel(int id) : base(id) { }

        #endregion

        #region methods

        /// <summary>
        /// Sets the value of a property of this mode
        /// </summary>
        /// <param name="skill"></param>
        /// <param name="property"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetProperty(WeaponSkill skill, WeaponProperty property, float value)
        {
            return MtaShared.SetWeaponProperty(ID, skill.ToString().ToLower(), property.ToString().ToLower(), value);
        }

        /// <summary>
        /// Sets the value of a property of this mode
        /// </summary>
        /// <param name="skill"></param>
        /// <param name="property"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetProperty(WeaponSkill skill, WeaponProperty property, int value)
        {
            return MtaShared.SetWeaponProperty(ID, skill.ToString().ToLower(), property.ToString().ToLower(), value);
        }

        #endregion
    }
}
