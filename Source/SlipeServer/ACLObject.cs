using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Server.Interfaces;
using Slipe.MTADefinitions;

namespace Slipe.Server
{
    /// <summary>
    /// Superclass of an object that is able to be handled as an ACL object
    /// </summary>
    public class ACLObject : IACLObject
    {
        /// <summary>
        /// Returns the identifiable string e.g. user.{name}, resource.{name}
        /// </summary>
        public virtual string ACLIdentifier
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Check if the object has access to a given action
        /// </summary>
        public bool HasPermissionTo(string action, bool defaultPermission = true)
        {
            return MTAServer.HasObjectPermissionTo(ACLIdentifier, action, defaultPermission);
        }

        /// <summary>
        /// Check if the object is in a certain ACL group
        /// </summary>
        public bool IsInACLGroup(ACLGroup group)
        {
            return MTAServer.IsObjectInACLGroup(ACLIdentifier, group.ACL);
        }
    }
}
