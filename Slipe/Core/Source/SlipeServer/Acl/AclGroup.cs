using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Slipe.MTADefinitions;
using Slipe.Shared.Exceptions;

namespace Slipe.Server.Acl
{
    /// <summary>
    /// Class that represents a group of different ACL entries
    /// </summary>
    public class AclGroup
    {
        protected internal MTAAclGroup group;

        #region Properties

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
        /// Get an array of all ACL Entries in this group
        /// </summary>
        public AclEntry[] Entries
        {
            get
            {
                MTAAcl[] mtaentires = MTAShared.GetArrayFromTable(MTAServer.AclGroupListACL(group), "acl");
                AclEntry[] entries = new AclEntry[mtaentires.Length];
                for (int i = 0; i < mtaentires.Length; i++)
                {
                    entries[i] = new AclEntry(mtaentires[i]);
                }
                return entries;
            }
        }

        /// <summary>
        /// Get an array of all ACL objects in this group
        /// </summary>
        public IAclObject[] Objects
        {
            get
            {
                return MTAShared.GetArrayFromTable(MTAServer.AclGroupListObjects(group), "acl-object");
            }
        }

        /// <summary>
        /// Get all ACL groups on this server
        /// </summary>
        public static AclGroup[] All
        {
            get
            {
                MTAAclGroup[] mtagroups = MTAShared.GetArrayFromTable(MTAServer.AclGroupList(), "acl-group");
                AclGroup[] groups = new AclGroup[mtagroups.Length];
                for (int i = 0; i < mtagroups.Length; i++)
                {
                    groups[i] = new AclGroup(mtagroups[i]);
                }
                return groups;
            }
        }

        #endregion

        #region Constructors
        [EditorBrowsable(EditorBrowsableState.Never)]
        public AclGroup(MTAAclGroup mtaAclGroup)
        {
            group = mtaAclGroup;
        }

        /// <summary>
        /// Create a new ACL group
        /// </summary>
        public AclGroup(string name)
        {
            group = MTAServer.AclCreateGroup(name);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get an ACL group instance from the name of the group
        /// </summary>
        public static AclGroup Get(string name)
        {
            MTAAclGroup result = MTAServer.AclGetGroup(name);
            if (result == null)
            {
                throw new NullElementException("No ACL entry with the name " + name + " can be found");
            }
            return new AclGroup(result);
        }

        /// <summary>
        /// Add a new ACL entry to this group
        /// </summary>
        public bool AddEntry(AclEntry entry)
        {
            return MTAServer.AclGroupAddACL(group, entry.ACL);
        }

        /// <summary>
        /// Add a new object to this group
        /// </summary>
        public bool AddObject(IAclObject obj)
        {
            return MTAServer.AclGroupAddObject(group, obj.ACLIdentifier);
        }

        /// <summary>
        /// Remove an ACL entry from this group
        /// </summary>
        public bool RemoveEntry(AclEntry entry)
        {
            return MTAServer.AclGroupRemoveACL(group, entry.ACL);
        }

        /// <summary>
        /// Remove an ACL object form this group
        /// </summary>
        public bool RemoveObject(IAclObject obj)
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

        #endregion

    }
}
