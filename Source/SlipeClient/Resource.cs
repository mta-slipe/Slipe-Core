using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using Slipe.Shared;

namespace Slipe.Client
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
        /// his function retrieves a resource's GUI element.
        /// </summary>
        public Element GUIRoot
        {
            get
            {
                return ElementManager.Instance.GetElement(MTAClient.GetResourceGUIElement(_resource));
            }
        }

    }
}
