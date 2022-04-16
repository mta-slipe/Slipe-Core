using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Acl
{
    /// <summary>
    /// Struct representing a resource ACL request
    /// </summary>
    public struct AclRequest
    {
        public string Name;
        public bool Access;
        public bool Pending;
        public string Who;
        public string Date;

        /// <summary>
        /// Create a new ACLRequest
        /// </summary>
        public AclRequest(string name, bool access, bool pending, string who, string date)
        {
            Name = name;
            Access = access;
            Pending = pending;
            Who = who;
            Date = date;
        }

        /// <summary>
        /// Create an ACLRequest from an mta request table
        /// </summary>
        public AclRequest(dynamic request)
        {
            Name = request.name;
            Access = request.access;
            Pending = request.pending;
            Who = request.who;
            Date = request.date;
        }
    }
}
