using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;

namespace Slipe.Server.Acl
{
    /// <summary>
    /// Class that wraps static ACL functions
    /// </summary>
    public static class AclFile
    {
        /// <summary>
        /// This function reloads the ACL's and the ACL groups from the ACL XML file. All ACL and ACL group elements are invalid after a call to this and should not be used anymore.
        /// </summary>
        public static bool Reload()
        {
            return MtaServer.AclReload();
        }

        /// <summary>
        /// The ACL XML file is automatically saved whenever the ACL is modified, but the automatic save can be delayed by up to 10 seconds for performance reasons. Calling this function will force an immediate save.
        /// </summary>
        public static bool Save()
        {
            return MtaServer.AclSave();
        }
    }
}
