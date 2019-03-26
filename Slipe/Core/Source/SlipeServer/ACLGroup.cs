using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using Slipe.Shared.Exceptions;
using Slipe.Server.Interfaces;

namespace Slipe.Server
{
    /// <summary>
    /// Class that represents a group of different ACL entries
    /// </summary>
    public class ACLGroup
    {
        protected internal MTAAclGroup group;

        /// <summary>
        /// Creates an ACL Group class instance from an MTA aclgroup class
        /// </summary>
        public ACLGroup(MTAAclGroup mtaAclGroup)
        {
            group = mtaAclGroup;
        }

        /// <summary>
        /// Create a new ACL group
        /// </summary>
        public ACLGroup(string name)
        {
            group = MTAServer.AclCreateGroup(name);
        }

        /// <summary>
        /// Get an ACL group instance from the name of the group
        /// </summary>
        public static ACLGroup Get(string name)
        {
            MTAAclGroup result = MTAServer.AclGetGroup(name);
            if (result == null)
            {
                throw new NullElementException("No ACL entry with the name " + name + " can be found");
            }
            return new ACLGroup(result);
        }

        /// <summary>
        /// Return the MTAAClgroup class instance
        /// </summary>
        public MTAAclGroup ACL
        {
            get
            {
                return group;
            }
        }

        /// <summary>
        /// Get the name of this ACL group
        /// </summary>
        public string Name
        {
            get
            {
                return MTAServer.AclGroupGetName(group);
            }
        }

        /// <summary>
        /// Get all ACL groups on this server
        /// </summary>
        public static ACLGroup[] All
        {
            get
            {
                MTAAclGroup[] mtagroups = MTAShared.GetArrayFromTable(MTAServer.AclGroupList(), "acl-group");
                ACLGroup[] groups = new ACLGroup[mtagroups.Length];
                for (int i = 0; i < mtagroups.Length; i++)
                {
                    groups[i] = new ACLGroup(mtagroups[i]);
                }
                return groups;
            }
        }

        /// <summary>
        /// Get an array of all ACL Entries in this group
        /// </summary>
        public ACLEntry[] Entries
        {
            get
            {
                MTAAcl[] mtaentires = MTAShared.GetArrayFromTable(MTAServer.AclGroupListACL(group), "acl");
                ACLEntry[] entries = new ACLEntry[mtaentires.Length];
                for (int i = 0; i < mtaentires.Length; i++)
                {
                    entries[i] = new ACLEntry(mtaentires[i]);
                }
                return entries;
            }
        }

        /// <summary>
        /// Get an array of all ACL objects in this group
        /// </summary>
        public IACLObject[] Objects
        {
            get
            {
                return MTAShared.GetArrayFromTable(MTAServer.AclGroupListObjects(group), "acl-object");
            }
        }

        /// <summary>
        /// Add a new ACL entry to this group
        /// </summary>
        public bool AddEntry(ACLEntry entry)
        {
            return MTAServer.AclGroupAddACL(group, entry.ACL);
        }

        /// <summary>
        /// Add a new object to this group
        /// </summary>
        public bool AddObject(IACLObject obj)
        {
            return MTAServer.AclGroupAddObject(group, obj.ACLIdentifier);
        }

        /// <summary>
        /// Remove an ACL entry from this group
        /// </summary>
        public bool RemoveEntry(ACLEntry entry)
        {
            return MTAServer.AclGroupRemoveACL(group, entry.ACL);
        }

        /// <summary>
        /// Remove an ACL object form this group
        /// </summary>
        public bool RemoveObject(IACLObject obj)
        {
            return MTAServer.AclGroupRemoveObject(group, obj.ACLIdentifier);
        }

        /// <summary>
        /// Delete this ACL group
        /// </summary>
        public bool Destroy()
        {
            return MTAServer.AclDestroyGroup(group);
        }
    }
}
