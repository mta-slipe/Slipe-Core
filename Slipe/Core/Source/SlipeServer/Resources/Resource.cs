using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Xml;
using Slipe.Shared.Elements;
using Slipe.Shared.Resources;
using Slipe.Server.Acl;
using System.ComponentModel;

namespace Slipe.Server.Resources
{
    /// <summary>
    /// Represents an MTA resource
    /// </summary>
    public class Resource : SharedResource
    {
        #region Properties

        /// <summary>
        /// Used to check the last starting time and date of a resource
        /// </summary>
        public DateTime LastStartTime
        {
            get
            {
                return MtaShared.GetDateTimeFromSecondStamp(MtaServer.GetResourceLastStartTime(MTAResource));
            }
        }

        /// <summary>
        /// This function retrieves the reason why a resource failed to start.
        /// </summary>
        public string LoadFailureReason
        {
            get
            {
                return MtaServer.GetResourceLoadFailureReason(MTAResource);
            }
        }

        /// <summary>
        /// Gets the date and time at which a resource was last loaded in the server.
        /// </summary>
        public DateTime LoadTime
        {
            get
            {
                return MtaShared.GetDateTimeFromSecondStamp(MtaServer.GetResourceLoadTime(MTAResource));
            }
        }

        /// <summary>
        /// This function returns the organizational file path of this resouce
        /// </summary>
        public string OrganizationalPath
        {
            get
            {
                return MtaServer.GetResourceOrganizationalPath(MTAResource);
            }
        }

        /// <summary>
        /// Checks whether a resource is currently archived (running from within a ZIP file).
        /// </summary>
        public bool IsArchived
        {
            get
            {
                return MtaServer.IsResourceArchived(MTAResource);
            }
        }

        /// <summary>
        /// This function retrieves the ACL request section from the meta.xml file of the given resource.
        /// </summary>
        public AclRequest[] ACLRequests
        {
            get
            {
                return MtaShared.GetArrayFromTable(MtaServer.GetResourceACLRequests(MTAResource), "acl-request");
            }
        }

        /// <summary>
        /// Static pointer to the current resource
        /// </summary>
        public static Resource This
        {
            get
            {
                return new Resource(MtaShared.GetThisResource());
            }
        }

        /// <summary>
        /// This function retrieves a table of all the resources that exist on the server.
        /// </summary>
        public static Resource[] All
        {
            get
            {
                MtaResource[] resourceList = MtaShared.GetArrayFromTable(MtaServer.GetResources(), "mta-resource");
                Resource[] resources = new Resource[resourceList.Length];
                for (int i = 0; i < resourceList.Length; i++)
                {
                    resources[i] = new Resource(resourceList[i]);
                }
                return resources;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a resource from an MTA resource element
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Resource(MtaResource resource) : base(resource) { }

        /// <summary>
        /// Create a new empty resource
        /// </summary>
        public Resource(string name, string organizationalDir = null) : base(MtaServer.CreateResource(name, organizationalDir)) { }

        #endregion

        #region Methods  

        /// <summary>
        /// This function changes the access for one ACL request of the given resource.
        /// </summary>
        public bool UpdateACLRequest(string rightName, bool access, string byWho = "")
        {
            return MtaServer.UpdateResourceACLRequest(MTAResource, rightName, access, byWho);
        }        

        /// <summary>
        /// This function retrieves the root element of a certain map in this resource
        /// </summary>
        public Element MapRoot(string mapName)
        {
            return ElementManager.Instance.GetElement(MtaServer.GetResourceMapRootElement(MTAResource, mapName));
        }

        /// <summary>
        /// Adds a new config to this resource
        /// </summary>
        public XmlNode AddConfig(string filePath, string fileType = "server")
        {
            MtaElement mtaNode = MtaServer.AddResourceConfig(filePath, fileType);

            XmlDocument document = new XmlDocument();
            XmlNode xmlNode = document.CreateElement(MtaShared.XmlNodeGetName(mtaNode));
            /*
            [[
            xmlNode:index(mtaNode)
            ]]
            */
            return xmlNode;
        }

        /// <summary>
        /// This function adds a new empty mapfile to this resource
        /// </summary>
        public XmlNode AddMap(string filePath, int dimension = 0)
        {
            MtaElement mtaNode = MtaServer.AddResourceMap(filePath, dimension);

            XmlDocument document = new XmlDocument();
            XmlNode xmlNode = document.CreateElement(MtaShared.XmlNodeGetName(mtaNode));
            /*
            [[
            xmlNode:index(mtaNode)
            ]]
            */
            return xmlNode;
        }

        /// <summary>
        /// This function deletes this resource from the MTA memory and moves it to the /resources-cache/trash/ directory.
        /// </summary>
        public bool Delete()
        {
            return MtaServer.DeleteResource(Name);
        }

        /// <summary>
        /// Refreshes the current resource
        /// </summary>
        public bool Refresh()
        {
            return MtaServer.RefreshResources(true, MTAResource);
        }

        /// <summary>
        /// This function removes a file from the resource.
        /// </summary>
        public bool RemoveFile(string fileName)
        {
            return MtaServer.RemoveResourceFile(MTAResource, fileName);
        }

        /// <summary>
        /// This function renames a resource.
        /// </summary>
        public bool Rename(string newName, string organizationalPath)
        {
            return MtaServer.RenameResource(Name, newName, organizationalPath);
        }

        /// <summary>
        /// This function restarts a running resource. Restarting will destroy all the elements that the resource has created (as stopping the resource does).
        /// </summary>
        public bool Restart(bool persistent = true, bool configs = true, bool maps = true, bool scripts = true, bool html = true, bool clientConfigs = true, bool clientScripts = true, bool clientFiles = true)
        {
            return MtaServer.RestartResource(MTAResource, persistent, configs, maps, scripts, html, clientConfigs, clientScripts, clientFiles);
        }

        /// <summary>
        /// This function retrieves the value of any attribute in a resource info tag.
        /// </summary>
        public string GetInfo(string attribute)
        {
            return MtaServer.GetResourceInfo(MTAResource, attribute);
        }

        /// <summary>
        /// This function sets the value of any attribute in a resource info tag.
        /// </summary>
        public bool SetInfo(string attribute, string value)
        {
            return MtaServer.SetResourceInfo(MTAResource, attribute, value);
        }

        /// <summary>
        /// This function starts a resource either persistently or as a dependency of the current resource.
        /// </summary>
        public bool Start(bool persistent = false, bool includedResources = true, bool configs = true, bool maps = true, bool scripts = true, bool html = true, bool clientConfigs = true, bool clientScripts = true, bool clientFiles = true)
        {
            return MtaServer.StartResource(MTAResource, persistent, includedResources, configs, maps, scripts, html, clientConfigs, clientScripts, clientFiles);
        }

        /// <summary>
        /// This function stops a running resource.
        /// </summary>
        public bool Stop()
        {
            return MtaServer.StopResource(MTAResource);
        }

        /// <summary>
        /// This function copies a specified resource with a new name
        /// </summary>
        public static Resource CopyFrom(Resource resource, string name, string organizationalDir = null)
        {
            return new Resource(MtaServer.CopyResource(resource.MTAResource, name, organizationalDir));
        }

        /// <summary>
        /// This function finds new resources and checks for changes to the current ones.
        /// </summary>
        public static bool RefreshAll()
        {
            return MtaServer.RefreshResources(true, null);
        }

        #endregion

    }
}
