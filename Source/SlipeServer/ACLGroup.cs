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
        /// Retrieve a list of all ACL groups on this server
        /// </summary>
        public static List<ACLGroup> List
        {
            get
            {
                List<ACLGroup> list = new List<ACLGroup>();
                List<dynamic> mtaList = MTAShared.GetListFromTable(MTAServer.AclGroupList());
                foreach (dynamic mtaACLGroupItem in mtaList)
                {
                    ACLGroup aclGroup = new ACLGroup((MTAAclGroup) mtaACLGroupItem);
                    if (aclGroup != null && aclGroup is ACLGroup)
                    {
                        list.Add(aclGroup);
                    }
                }

                return list;

            }
        }

        /// <summary>
        /// Retrieve a list of all ACL Entries in this group
        /// </summary>
        public List<ACLEntry> Entries
        {
            get
            {
                List<ACLEntry> list = new List<ACLEntry>();
                List<dynamic> mtaList = MTAShared.GetListFromTable(MTAServer.AclGroupListACL(group));
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
        /// Retrieve a list of all ACL objects in this group
        /// </summary>
        public List<IACLObject> Objects
        {
            get
            {
                List<IACLObject> list = new List<IACLObject>();
                List<dynamic> mtaList = MTAShared.GetListFromTable(MTAServer.AclGroupListObjects(group));
                foreach (dynamic mtaACLObject in mtaList)
                {
                    //TODO: Once accounts and resources have been added, cast the objects to their respecive classes
                }

                return list;
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
