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
    }
}
