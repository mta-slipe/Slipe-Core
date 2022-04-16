using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Exceptions;

namespace SlipeLua.Server.Acl
{
    /// <summary>
    /// Class that represents a group of different ACL entries
    /// </summary>
    public class AclGroup
    {
        protected internal MtaAclGroup group;

        #region Properties

        /// <summary>
        /// Return the MTAAClgroup class instance
        /// </summary>
        public MtaAclGroup ACL
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
                return MtaServer.AclGroupGetName(group);
            }
        }

        /// <summary>
        /// Get an array of all ACL Entries in this group
        /// </summary>
        public AclEntry[] Entries
        {
            get
            {
                MtaAcl[] mtaentires = MtaShared.GetArrayFromTable(MtaServer.AclGroupListACL(group), "acl");
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
                return MtaShared.GetArrayFromTable(MtaServer.AclGroupListObjects(group), "acl-object");
            }
        }

        /// <summary>
        /// Get all ACL groups on this server
        /// </summary>
        public static AclGroup[] All
        {
            get
            {
                MtaAclGroup[] mtagroups = MtaShared.GetArrayFromTable(MtaServer.AclGroupList(), "acl-group");
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
        public AclGroup(MtaAclGroup mtaAclGroup)
        {
            group = mtaAclGroup;
        }

        /// <summary>
        /// Create a new ACL group
        /// </summary>
        public AclGroup(string name)
            : this(MtaServer.AclCreateGroup(name)) { }

        #endregion

        #region Methods

        /// <summary>
        /// Get an ACL group instance from the name of the group
        /// </summary>
        public static AclGroup Get(string name)
        {
            MtaAclGroup result = MtaServer.AclGetGroup(name);
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
            return MtaServer.AclGroupAddACL(group, entry.ACL);
        }

        /// <summary>
        /// Add a new object to this group
        /// </summary>
        public bool AddObject(IAclObject obj)
        {
            return MtaServer.AclGroupAddObject(group, obj.AclIdentifier);
        }

        /// <summary>
        /// Remove an ACL entry from this group
        /// </summary>
        public bool RemoveEntry(AclEntry entry)
        {
            return MtaServer.AclGroupRemoveACL(group, entry.ACL);
        }

        /// <summary>
        /// Remove an ACL object form this group
        /// </summary>
        public bool RemoveObject(IAclObject obj)
        {
            return MtaServer.AclGroupRemoveObject(group, obj.AclIdentifier);
        }

        /// <summary>
        /// Delete this ACL group
        /// </summary>
        public bool Destroy()
        {
            return MtaServer.AclDestroyGroup(group);
        }

        #endregion

    }
}
