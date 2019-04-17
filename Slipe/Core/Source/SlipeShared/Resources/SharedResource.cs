using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Xml;
using Slipe.Shared.Elements;
using Slipe.Exports;

namespace Slipe.Shared.Resources
{
    /// <summary>
    /// Represents an MTA resource
    /// </summary>
    public class SharedResource
    {
        #region Properties

        public MtaResource MTAResource { get; }

        /// <summary>
        /// Get the name of this resource
        /// </summary>
        public string Name
        {
            get
            {
                return MtaShared.GetResourceName(MTAResource);
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
                return ElementManager.Instance.GetElement(MtaShared.GetResourceDynamicElementRoot(MTAResource));
            }
        }

        /// <summary>
        /// This function retrieves a resource's root element. 
        /// </summary>
        public Element Root
        {
            get
            {
                return ElementManager.Instance.GetElement(MtaShared.GetResourceRootElement(MTAResource));
            }
        }

        /// <summary>
        /// This function returns the state of a given resource
        /// </summary>
        public string State
        {
            get
            {
                return MtaShared.GetResourceState(MTAResource);
            }
        }

        /// <summary>
        /// Returns an array containing the names of the functions that a resource exports. 
        /// </summary>
        public string[] ExportedFunctions
        {
            get
            {
                return MtaShared.GetArrayFromTable(MtaShared.GetResourceExportedFunctions(MTAResource), "System.String");
            }
        }

        /// <summary>
        /// This function is used to return the root node of a configuration file.
        /// </summary>
        public XmlNode Config(string filePath)
        {
            MtaElement mtaNode = MtaShared.GetResourceConfig(filePath);

            XmlDocument document = new XmlDocument();
            XmlNode xmlNode = document.CreateElement(MtaShared.XmlNodeGetName(mtaNode));
            /*
            [[
            xmlNode:index(mtaNode)
            ]]
            */
            return xmlNode;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a resource from an MTA resource element
        /// </summary>
        public SharedResource(MtaResource resource)
        {
            MTAResource = resource;
        }

        #endregion

        /// <summary>
        /// This function is used to retrieve a resource from its name. A resource's name is the same as its folder or file archive name on the server (without the extension).
        /// </summary>
        public static SharedResource FromName(string name)
        {
            return new SharedResource(MtaShared.GetResourceFromName(name));
        }

        public object Invoke(string functionName, params object[] parameters)
        {
            /*
            [[
                do
	                local export = exports[this:getName()]
                    return export[functionName](export, unpack(parameters))	
                end
            ]]
            */
            return Export.Invoke(this.Name, functionName, parameters);
        }
    }
}
