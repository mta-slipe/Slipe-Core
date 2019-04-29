using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using Slipe.Shared.Resources;

namespace Slipe.Client.Resources
{
    /// <summary>
    /// Represents an MTA resource
    /// </summary>
    public class Resource : SharedResource
    {
        private static Dictionary<object, Resource> resources = new Dictionary<object, Resource>();

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
        /// This function retrieves a resource's GUI element.
        /// </summary>
        public Element GuiRoot
        {
            get
            {
                return ElementManager.Instance.GetElement(MtaClient.GetResourceGUIElement(MtaResource));
            }
        }

        #region Constructor

        [EditorBrowsable(EditorBrowsableState.Never)]
        internal Resource(MtaResource resource)
        {
            resources.Add(resource, this);
            MtaResource = resource;
        }

        /// <summary>
        /// Only used to extend a specific resource class
        /// </summary>
        /// <param name="name">The name of the resource</param>
        protected Resource(string name) : this(MtaShared.GetResourceFromName(name)) { }

        #endregion

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

        /// <summary>
        /// This function is used to retrieve a resource from its name. A resource's name is the same as its folder or file archive name on the server (without the extension).
        /// </summary>
        public static Resource Get(string name)
        {
            return Get(MtaShared.GetResourceFromName(name));
        }

        #region Events

        internal void HandleStart()
        {
            OnStart?.Invoke();
        }

        internal void HandleStop()
        {
            OnStop?.Invoke();
        }

        public delegate void OnStartHandler();
        public event OnStartHandler OnStart;

        public delegate void OnStopHandler();
        public event OnStopHandler OnStop;

        #endregion

    }
}
