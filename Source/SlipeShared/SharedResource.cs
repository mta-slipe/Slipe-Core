using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Xml;

namespace Slipe.Shared
{
    /// <summary>
    /// Represents an MTA resource
    /// </summary>
    public class SharedResource
    {
        protected MTAResource _resource;

        public MTAResource MTAResource
        {
            get
            {
                return _resource;
            }
        }

        /// <summary>
        /// Create a resource from an MTA resource element
        /// </summary>
        public SharedResource(MTAResource resource)
        {
            _resource = resource;
        }

        /// <summary>
        /// This function is used to retrieve a resource from its name. A resource's name is the same as its folder or file archive name on the server (without the extension).
        /// </summary>
        public static SharedResource FromName(string name)
        {
            return new SharedResource(MTAShared.GetResourceFromName(name));
        }

        /// <summary>
        /// Get the name of this resource
        /// </summary>
        public string Name
        {
            get
            {
                return MTAShared.GetResourceName(_resource);
            }
        }

        /// <summary>
        /// This function retrieves the dynamic element root of a specified resource. 
        /// The dynamic element root is the parent of elements that are created by scripts unless they specify a different parent.
        /// </summary>
        public Element DynamicRoot
        {
            get
            {
                return ElementManager.Instance.GetElement(MTAShared.GetResourceDynamicElementRoot(_resource));
            }
        }

        /// <summary>
        /// This function retrieves a resource's root element. 
        /// </summary>
        public Element Root
        {
            get
            {
                return ElementManager.Instance.GetElement(MTAShared.GetResourceRootElement(_resource));
            }
        }

        /// <summary>
        /// This function returns the state of a given resource
        /// </summary>
        public string State
        {
            get
            {
                return MTAShared.GetResourceState(_resource);
            }
        }

        /// <summary>
        /// Returns an array containing the names of the functions that a resource exports. 
        /// </summary>
        public string[] ExportedFunctions
        {
            get
            {
                return MTAShared.GetArrayFromTable(MTAShared.GetResourceExportedFunctions(_resource), "System.String");
            }
        }

        /// <summary>
        /// This function is used to return the root node of a configuration file.
        /// </summary>
        public XmlNode Config(string filePath)
        {
            return MTAShared.GetResourceConfig(filePath);
        }

        




    }
}
