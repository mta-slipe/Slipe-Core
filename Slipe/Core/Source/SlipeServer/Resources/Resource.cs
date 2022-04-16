using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;
using System.Xml;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Resources;
using SlipeLua.Server.Acl;
using System.ComponentModel;
using SlipeLua.Server.Game;

namespace SlipeLua.Server.Resources
{
    /// <summary>
    /// Represents an MTA resource
    /// </summary>
    public class Resource : SharedResource
    {
        private static Dictionary<object, Resource> resources = new Dictionary<object, Resource>();

        #region Properties

        /// <summary>
        /// Used to check the last starting time and date of a resource
        /// </summary>
        public DateTime LastStartTime
        {
            get
            {
                return MtaShared.GetDateTimeFromSecondStamp(MtaServer.GetResourceLastStartTime(MtaResource));
            }
        }

        /// <summary>
        /// This function retrieves the reason why a resource failed to start.
        /// </summary>
        public string LoadFailureReason
        {
            get
            {
                return MtaServer.GetResourceLoadFailureReason(MtaResource);
            }
        }

        /// <summary>
        /// Gets the date and time at which a resource was last loaded in the server.
        /// </summary>
        public DateTime LoadTime
        {
            get
            {
                return MtaShared.GetDateTimeFromSecondStamp(MtaServer.GetResourceLoadTime(MtaResource));
            }
        }

        /// <summary>
        /// This function returns the organizational file path of this resouce
        /// </summary>
        public string OrganizationalPath
        {
            get
            {
                return MtaServer.GetResourceOrganizationalPath(MtaResource);
            }
        }

        /// <summary>
        /// Checks whether a resource is currently archived (running from within a ZIP file).
        /// </summary>
        public bool IsArchived
        {
            get
            {
                return MtaServer.IsResourceArchived(MtaResource);
            }
        }

        /// <summary>
        /// This function retrieves the ACL request section from the meta.xml file of the given resource.
        /// </summary>
        public AclRequest[] ACLRequests
        {
            get
            {
                return MtaShared.GetArrayFromTable(MtaServer.GetResourceACLRequests(MtaResource), "acl-request");
            }
        }

        /// <summary>
        /// Static pointer to the current resource
        /// </summary>
        private static Resource thisResource;
        public static Resource This
        {
            get
            {
                thisResource = thisResource ?? Get(MtaShared.GetThisResource());
                return thisResource;
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
                return CastMultiple(resourceList);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a resource from an MTA resource element
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected Resource(MtaResource resource)
        {
            resources.Add(resource, this);
            MtaResource = resource;

            GameServer.OnStart += (Elements.ResourceRootElement source, Game.Events.OnStartEventArgs eventArgs) =>
            {
                if (eventArgs.Resource.MtaResource != this.MtaResource)
                {
                    return;
                }
                OnStart?.Invoke();
            };

            GameServer.OnPreStart += (Elements.ResourceRootElement source, Game.Events.OnPreStartEventArgs eventArgs) =>
            {
                if (eventArgs.Resource.MtaResource != this.MtaResource)
                {
                    return;
                }
                OnPreStart?.Invoke();
            };

            GameServer.OnStop += (Elements.ResourceRootElement source, Game.Events.OnStopEventArgs eventArgs) =>
            {
                if (eventArgs.Resource.MtaResource != this.MtaResource)
                {
                    return;
                }
                OnStop?.Invoke();
            };
        }

        /// <summary>
        /// Only used to extend a specific resource class
        /// </summary>
        /// <param name="name">The name of the resource</param>
        protected Resource(string name) : this(MtaShared.GetResourceFromName(name)) { }

        /// <summary>
        /// Create a new empty resource
        /// </summary>
        public Resource(string name, string organizationalDir = null) : this(MtaServer.CreateResource(name, organizationalDir)) { }

        #endregion

        #region Methods  

        /// <summary>
        /// This function changes the access for one ACL request of the given resource.
        /// </summary>
        public bool UpdateACLRequest(string rightName, bool access, string byWho = "")
        {
            return MtaServer.UpdateResourceACLRequest(MtaResource, rightName, access, byWho);
        }        

        /// <summary>
        /// This function retrieves the root element of a certain map in this resource
        /// </summary>
        public Element MapRoot(string mapName)
        {
            return ElementManager.Instance.GetElement(MtaServer.GetResourceMapRootElement(MtaResource, mapName));
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
            return MtaServer.RefreshResources(true, MtaResource);
        }

        /// <summary>
        /// This function removes a file from the resource.
        /// </summary>
        public bool RemoveFile(string fileName)
        {
            return MtaServer.RemoveResourceFile(MtaResource, fileName);
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
            return MtaServer.RestartResource(MtaResource, persistent, configs, maps, scripts, html, clientConfigs, clientScripts, clientFiles);
        }

        /// <summary>
        /// This function retrieves the value of any attribute in a resource info tag.
        /// </summary>
        public string GetInfo(string attribute)
        {
            return MtaServer.GetResourceInfo(MtaResource, attribute);
        }

        /// <summary>
        /// This function sets the value of any attribute in a resource info tag.
        /// </summary>
        public bool SetInfo(string attribute, string value)
        {
            return MtaServer.SetResourceInfo(MtaResource, attribute, value);
        }

        /// <summary>
        /// This function starts a resource either persistently or as a dependency of the current resource.
        /// </summary>
        public bool Start(bool persistent = false, bool includedResources = true, bool configs = true, bool maps = true, bool scripts = true, bool html = true, bool clientConfigs = true, bool clientScripts = true, bool clientFiles = true)
        {
            return MtaServer.StartResource(MtaResource, persistent, includedResources, configs, maps, scripts, html, clientConfigs, clientScripts, clientFiles);
        }

        /// <summary>
        /// This function stops a running resource.
        /// </summary>
        public bool Stop()
        {
            return MtaServer.StopResource(MtaResource);
        }

        /// <summary>
        /// This function copies a specified resource with a new name
        /// </summary>
        public static Resource CopyFrom(Resource resource, string name, string organizationalDir = null)
        {
            return Get(MtaServer.CopyResource(resource.MtaResource, name, organizationalDir));
        }

        /// <summary>
        /// This function finds new resources and checks for changes to the current ones.
        /// </summary>
        public static bool RefreshAll()
        {
            return MtaServer.RefreshResources(true, null);
        }

        /// <summary>
        /// This function is used to retrieve a resource from its name. A resource's name is the same as its folder or file archive name on the server (without the extension).
        /// </summary>
        public static Resource Get(string name)
        {
            return Get(MtaShared.GetResourceFromName(name));
        }

        internal static Resource Get(MtaResource resource)
        {
            if (resource == null)
            {
                return null;
            }
            if (!resources.ContainsKey(resource))
            {
                return new Resource(resource);
            }
            return resources[resource];
        }

        internal static Resource[] CastMultiple(MtaResource[] _resources)
        {
            Resource[] result = new Resource[_resources.Length];
            for (int i = 0; i < _resources.Length; i++)
            {
                result[i] = Get(_resources[i]);
            }
            return result;
        }

        #endregion

        #region Events
        
        public delegate void OnPreStartHandler();
        public event OnPreStartHandler OnPreStart;

        public delegate void OnStartHandler();
        public event OnStartHandler OnStart;

        public delegate void OnStopHandler();
        public event OnStopHandler OnStop;

        #endregion

    }
}
