using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using Slipe.Shared.Exceptions;
using Slipe.Server.Enums;

namespace Slipe.Server
{
    /// <summary>
    /// ACL or Access Control List is a set of rights grouped together to create a list
    /// </summary>
    public class ACLEntry
    {
        protected internal MTAAcl entry;

        /// <summary>
        /// Create an ACl entry from an MTA ACL class
        /// </summary>
        public ACLEntry(MTAAcl mtaAclEntry)
        {
            entry = mtaAclEntry;
        }

        /// <summary>
        /// Create a new ACL entry
        /// </summary>
        public ACLEntry(string name)
        {
            entry = MTAServer.AclCreate(name);
        }

        /// <summary>
        /// Get an existing ACL entry from its name
        /// </summary>
        public static ACLEntry Get(string name)
        {
            MTAAcl result = MTAServer.AclGet(name);
            if(result == null)
            {
                throw new NullElementException("No ACL entry with the name " + name + " can be found");
            }
            return new ACLEntry(result);
        }

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
        public static ACLEntry[] All
        {
            get
            {
                MTAAcl[] mtaAcls = MTAShared.GetArrayFromTable(MTAServer.AclList(), "acl");
                ACLEntry[] acls = new ACLEntry[mtaAcls.Length];
                for (int i = 0; i < mtaAcls.Length; i++)
                {
                    acls[i] = new ACLEntry(mtaAcls[i]);
                }
                return acls;
            }
        }

        /// <summary>
        /// Get an array of all rights on this ACL entry
        /// </summary>
        public string[] GetRights(ACLRightEnum rightType)
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
    }
}
