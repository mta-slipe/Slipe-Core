using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using Slipe.Shared;
using System.Xml;
using Slipe.Server.Structs;

namespace Slipe.Server
{
    /// <summary>
    /// Represents an MTA resource
    /// </summary>
    public class Resource : SharedResource
    {
        /// <summary>
        /// Create a resource from an MTA resource element
        /// </summary>
        public Resource(MTAResource resource) : base(resource) { }

        /// <summary>
        /// Create a new empty resource
        /// </summary>
        public Resource(string name, string organizationalDir = null) : base(MTAServer.CreateResource(name, organizationalDir)) { }

        /// <summary>
        /// Static pointer to the current resource
        /// </summary>
        public static Resource This
        {
            get
            {
                return new Resource(MTAShared.GetThisResource());
            }
        }

        /// <summary>
        /// This function retrieves a table of all the resources that exist on the server.
        /// </summary>
        public static Resource[] All
        {
            get
            {
                MTAResource[] resourceList = MTAShared.GetArrayFromTable(MTAServer.GetResources(), "mta-resource");
                Resource[] resources = new Resource[resourceList.Length];
                for (int i = 0; i < resourceList.Length; i++)
                {
                    resources[i] = new Resource(resourceList[i]);
                }
                return resources;
            }
        }

        /// <summary>
        /// This function copies a specified resource with a new name
        /// </summary>
        public static Resource CopyFrom(Resource resource, string name, string organizationalDir = null)
        {
            return new Resource(MTAServer.CopyResource(resource.MTAResource, name, organizationalDir));
        }

        /// <summary>
        /// This function retrieves the ACL request section from the meta.xml file of the given resource.
        /// </summary>
        public ACLRequest[] ACLRequests
        {
            get
            {
                return MTAShared.GetArrayFromTable(MTAServer.GetResourceACLRequests(_resource), "acl-request");
            }
        }

        /// <summary>
        /// This function changes the access for one ACL request of the given resource.
        /// </summary>
        public bool UpdateACLRequest(string rightName, bool access, string byWho = "")
        {
            return MTAServer.UpdateResourceACLRequest(_resource, rightName, access, byWho);
        }

        /// <summary>
        /// Used to check the last starting time and date of a resource
        /// </summary>
        public DateTime LastStartTime
        {
            get
            {
                return MTAShared.GetDateTimeFromSecondStamp(MTAServer.GetResourceLastStartTime(_resource));
            }
        }

        /// <summary>
        /// This function retrieves the reason why a resource failed to start.
        /// </summary>
        public string LoadFailureReason
        {
            get
            {
                return MTAServer.GetResourceLoadFailureReason(_resource);
            }
        }

        /// <summary>
        /// Gets the date and time at which a resource was last loaded in the server.
        /// </summary>
        public DateTime LoadTime
        {
            get
            {
                return MTAShared.GetDateTimeFromSecondStamp(MTAServer.GetResourceLoadTime(_resource));
            }
        }

        /// <summary>
        /// This function returns the organizational file path of this resouce
        /// </summary>
        public string OrganizationalPath
        {
            get
            {
                return MTAServer.GetResourceOrganizationalPath(_resource);
            }
        }

        /// <summary>
        /// Checks whether a resource is currently archived (running from within a ZIP file).
        /// </summary>
        public bool IsArchived
        {
            get
            {
                return MTAServer.IsResourceArchived(_resource);
            }
        }

        /// <summary>
        /// This function retrieves the root element of a certain map in this resource
        /// </summary>
        public Element MapRoot(string mapName)
        {
            return ElementManager.Instance.GetElement(MTAServer.GetResourceMapRootElement(_resource, mapName));
        }

        /// <summary>
        /// Adds a new config to this resource
        /// </summary>
        public XmlNode AddConfig(string filePath, string fileType = "server")
        {
            return MTAServer.AddResourceConfig(filePath, fileType);
        }

        /// <summary>
        /// This function adds a new empty mapfile to this resource
        /// </summary>
        public XmlNode AddMap(string filePath, int dimension = 0)
        {
            return MTAServer.AddResourceMap(filePath, dimension);
        }

        /// <summary>
        /// This function deletes this resource from the MTA memory and moves it to the /resources-cache/trash/ directory.
        /// </summary>
        public bool Delete()
        {
            return MTAServer.DeleteResource(Name);
        }

        /// <summary>
        /// Refreshes the current resource
        /// </summary>
        public bool Refresh()
        {
            return MTAServer.RefreshResources(true, _resource);
        }

        /// <summary>
        /// This function finds new resources and checks for changes to the current ones.
        /// </summary>
        public static bool RefreshAll()
        {
            return MTAServer.RefreshResources(true, null);
        }

        /// <summary>
        /// This function removes a file from the resource.
        /// </summary>
        public bool RemoveFile(string fileName)
        {
            return MTAServer.RemoveResourceFile(_resource, fileName);
        }

        /// <summary>
        /// This function renames a resource.
        /// </summary>
        public bool Rename(string newName, string organizationalPath)
        {
            return MTAServer.RenameResource(Name, newName, organizationalPath);
        }

        /// <summary>
        /// This function restarts a running resource. Restarting will destroy all the elements that the resource has created (as stopping the resource does).
        /// </summary>
        public bool Restart(bool persistent = true, bool configs = true, bool maps = true, bool scripts = true, bool html = true, bool clientConfigs = true, bool clientScripts = true, bool clientFiles = true)
        {
            return MTAServer.RestartResource(_resource, persistent, configs, maps, scripts, html, clientConfigs, clientScripts, clientFiles);
        }

        /// <summary>
        /// This function retrieves the value of any attribute in a resource info tag.
        /// </summary>
        public string GetInfo(string attribute)
        {
            return MTAServer.GetResourceInfo(_resource, attribute);
        }

        /// <summary>
        /// This function sets the value of any attribute in a resource info tag.
        /// </summary>
        public bool SetInfo(string attribute, string value)
        {
            return MTAServer.SetResourceInfo(_resource, attribute, value);
        }

        /// <summary>
        /// This function starts a resource either persistently or as a dependency of the current resource.
        /// </summary>
        public bool Start(bool persistent = false, bool includedResources = true, bool configs = true, bool maps = true, bool scripts = true, bool html = true, bool clientConfigs = true, bool clientScripts = true, bool clientFiles = true)
        {
            return MTAServer.StartResource(_resource, persistent, includedResources, configs, maps, scripts, html, clientConfigs, clientScripts, clientFiles);
        }

        /// <summary>
        /// This function stops a running resource.
        /// </summary>
        public bool Stop()
        {
            return MTAServer.StopResource(_resource);
        }


    }
}
