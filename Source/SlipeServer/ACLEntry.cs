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
        /// Retrieve a list of all ACL entries on this server
        /// </summary>
        public static List<ACLEntry> List
        {
            get
            {
                List<ACLEntry> list = new List<ACLEntry>();
                List<dynamic> mtaList = MTAShared.GetListFromTable(MTAServer.AclList());
                foreach (dynamic mtaACLEntry in mtaList)
                {
                    ACLEntry aclEntry = new ACLEntry((MTAAcl) mtaACLEntry);
                    if (aclEntry != null && aclEntry is ACLEntry)
                    {
                        list.Add(aclEntry);
                    }
                }

                return list;
            }
        }

        /// <summary>
        /// Retrieve a list of all rights on this ACL entry
        /// </summary>
        public List<string> ListRights(ACLRightEnum rightType)
        {
            List<string> list = new List<string>();
            List<dynamic> mtaList = MTAShared.GetListFromTable(MTAServer.AclListRights(entry, rightType.ToString().ToLower()));
            foreach (dynamic mtaAclRight in mtaList)
            {
                string right = Convert.ToString(mtaAclRight);
                list.Add(right);
            }

            return list;
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
