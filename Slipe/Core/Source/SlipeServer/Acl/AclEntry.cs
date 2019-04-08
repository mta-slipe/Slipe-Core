using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using Slipe.Shared.Exceptions;
using System.ComponentModel;

namespace Slipe.Server.Acl
{
    /// <summary>
    /// ACL or Access Control List is a set of rights grouped together to create a list
    /// </summary>
    public class AclEntry
    {
        protected internal MTAAcl entry;

        #region Properties

        /// <summary>
        /// Returns the MTA ACL class instance
        /// </summary>
        public MTAAcl ACL
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
                return MTAServer.AclGetName(entry);
            }
        }

        /// <summary>
        /// Get an array of all ACL entries on this server
        /// </summary>
        public static AclEntry[] All
        {
            get
            {
                MTAAcl[] mtaAcls = MTAShared.GetArrayFromTable(MTAServer.AclList(), "acl");
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
        public AclEntry(MTAAcl mtaAclEntry)
        {
            entry = mtaAclEntry;
        }

        /// <summary>
        /// Create a new ACL entry
        /// </summary>
        public AclEntry(string name)
        {
            entry = MTAServer.AclCreate(name);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get an array of all rights on this ACL entry
        /// </summary>
        public string[] GetRights(AclRightEnum rightType)
        {
            return MTAShared.GetArrayFromTable(MTAServer.AclListRights(entry, rightType.ToString().ToLower()), "System.String");
        }

        /// <summary>
        /// Get a right by its name
        /// </summary>
        public bool GetRight(string right)
        {
            return MTAServer.AclGetRight(entry, right);
        }

        /// <summary>
        /// Set a new right on this ACL entry
        /// </summary>
        public bool SetRight(string right, bool hasAccess)
        {
            return MTAServer.AclSetRight(entry, right, hasAccess);
        }

        /// <summary>
        /// Removes a right form this ACL entry
        /// </summary>
        public bool RemoveRight(string right)
        {
            return MTAServer.AclRemoveRight(entry, right);
        }

        /// <summary>
        /// Removes this ACL entry
        /// </summary>
        public bool Destroy()
        {
            return MTAServer.AclDestroy(entry);
        }

        /// <summary>
        /// Get an existing ACL entry from its name
        /// </summary>
        public static AclEntry Get(string name)
        {
            MTAAcl result = MTAServer.AclGet(name);
            if (result == null)
            {
                throw new NullElementException("No ACL entry with the name " + name + " can be found");
            }
            return new AclEntry(result);
        }

        #endregion

    }
}
