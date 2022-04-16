using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Acl
{
    /// <summary>
    /// Represents different types of ACL rights
    /// </summary>
    public enum AclRightEnum
    {
        GENERAL,
        FUNCTION,
        RESOURCE,
        COMMAND
    }
}
