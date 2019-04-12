using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using Slipe.Shared.Resources;

namespace Slipe.Client.Resources
{
    /// <summary>
    /// Manages resources
    /// </summary>
    public class ResourceManager
    {
        private static ResourceManager instance;
        private Dictionary<object, Resource> resources;

        /// <summary>
        /// Get the singleton instance of this class
        /// </summary>
        public static ResourceManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new ResourceManager();
                return instance;
            }
        }

        protected ResourceManager()
        {
            resources = new Dictionary<object, Resource>();
        }

        /// <summary>
        /// Registers an resource class
        /// </summary>
        public void RegisterResource(Resource resource)
        {
            resources.Add(resource.MTAResource, resource);
        }

        /// <summary>
        /// Gets an resource class instance given a certain MTA resource
        /// </summary>
        public Resource GetResource(MtaResource resource)
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
        /// Cast an array of MTAResources to a desired type
        /// </summary>
        public Resource[] CastMultiple(MtaResource[] resources)
        {
            Resource[] result = new Resource[resources.Length];
            for (int i = 0; i < resources.Length; i++)
            {
                result[i] = Instance.GetResource(resources[i]);
            }
            return result;
        }
    }
}
