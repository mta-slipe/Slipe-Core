using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Game
{
    public static class Settings
    {
        /// <summary>
        /// Stores arbitrary data in settings registry
        /// </summary>
        /// <param name="setting"></param>
        /// <param name="value"></param>
        public static void Set(string setting, dynamic value)
        {
            SlipeLua.MtaDefinitions.MtaServer.Set(setting, value);
        }

        /// <summary>
        /// Retrieves arbitrary data from settings registry
        /// </summary>
        /// <param name="setting"></param>
        /// <returns></returns>
        public static dynamic Get(string setting)
        {
            return SlipeLua.MtaDefinitions.MtaServer.Get(setting);
        }
    }
}
