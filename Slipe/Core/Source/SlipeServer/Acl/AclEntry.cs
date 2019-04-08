using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using Slipe.Shared.Exceptions;
using System.ComponentModel;

namespace Slipe.Server.Acl
{
    /// <summary>
    /// ACL or Access Control List is a set of rights grouped together to create a list
    /// </summary>
    public class AclEntry
    {
        protected internal MtaAcl entry;

        #region Properties

        /// <summary>
        /// Returns the MTA ACL class instance
        /// </summary>
        public MtaAcl ACL
        {
            get
            {
                return entry;
            }
        }

        /// <summary>
        /// Return the name of this ACL entry
        /// </summary>
        public string Name
        {
            get
            {
                return MtaServer.AclGetName(entry);
            }
        }

        /// <summary>
        /// Get an array of all ACL entries on this server
        /// </summary>
        public static AclEntry[] All
        {
            get
            {
                MtaAcl[] mtaAcls = MtaShared.GetArrayFromTable(MtaServer.AclList(), "acl");
                AclEntry[] acls = new AclEntry[mtaAcls.Length];
                for (int i = 0; i < mtaAcls.Length; i++)
                {
                    acls[i] = new AclEntry(mtaAcls[i]);
                }
                return acls;
            }
        }

        #endregion

        #region Constructors 

        [EditorBrowsable(EditorBrowsableState.Never)]
        public AclEntry(MtaAcl mtaAclEntry)
        {
            entry = mtaAclEntry;
        }

        /// <summary>
        /// Create a new ACL entry
        /// </summary>
        public AclEntry(string name)
        {
            entry = MtaServer.AclCreate(name);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get an array of all rights on this ACL entry
        /// </summary>
        public string[] GetRights(AclRightEnum rightType)
        {
            return MtaShared.GetArrayFromTable(MtaServer.AclListRights(entry, rightType.ToString().ToLower()), "System.String");
        }

        /// <summary>
        /// Get a right by its name
        /// </summary>
        public bool GetRight(string right)
        {
            return MtaServer.AclGetRight(entry, right);
        }

        /// <summary>
        /// Set a new right on this ACL entry
        /// </summary>
        public bool SetRight(string right, bool hasAccess)
        {
            return MtaServer.AclSetRight(entry, right, hasAccess);
        }

        /// <summary>
        /// Removes a right form this ACL entry
        /// </summary>
        public bool RemoveRight(string right)
        {
            return MtaServer.AclRemoveRight(entry, right);
        }

        /// <summary>
        /// Removes this ACL entry
        /// </summary>
        public bool Destroy()
        {
            return MtaServer.AclDestroy(entry);
        }

        /// <summary>
        /// Get an existing ACL entry from its name
        /// </summary>
        public static AclEntry Get(string name)
        {
            MtaAcl result = MtaServer.AclGet(name);
            if (result == null)
            {
                throw new NullElementException("No ACL entry with the name " + name + " can be found");
            }
            return new AclEntry(result);
        }

        #endregion

    }
}
