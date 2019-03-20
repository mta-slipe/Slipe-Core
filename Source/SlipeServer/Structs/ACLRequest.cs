using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Structs
{
    /// <summary>
    /// Struct representing a resource ACL request
    /// </summary>
    public struct ACLRequest
    {
        public string Name;
        public bool Access;
        public bool Pending;
        public string Who;
        public string Date;

        /// <summary>
        /// Create a new ACLRequest
        /// </summary>
        public ACLRequest(string name, bool access, bool pending, string who, string date)
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
        public ACLRequest(dynamic request)
        {
            Name = request.name;
            Access = request.access;
            Pending = request.pending;
            Who = request.who;
            Date = request.date;
        }
    }
}
