using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Interfaces
{
    /// <summary>
    /// Interface representing objects that can be entries in an MTA ACL
    /// </summary>
    public interface IACLObject
    {
        /// <summary>
        /// Formatted ACL entry; example: user.{name} or resource.{name}
        /// </summary>
        string ACLIdentifier
        {
            get;
        }

        /// <summary>
        /// Check if the object has access to a given action
        /// </summary>
        bool HasPermissionTo(string action, bool defaultPermission = true);

        /// <summary>
        /// Check if the object is in a certain ACL group
        /// </summary>
        bool IsInACLGroup(ACLGroup group);
    }
}
