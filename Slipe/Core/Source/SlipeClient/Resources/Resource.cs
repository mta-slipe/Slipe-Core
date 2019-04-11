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
        /// This function retrieves a resource's GUI element.
        /// </summary>
        public Element GuiRoot
        {
            get
            {
                return ElementManager.Instance.GetElement(MtaClient.GetResourceGUIElement(MTAResource));
            }
        }

        #region Constructor

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Resource(MtaResource resource) : base(resource) { }

        #endregion
    }
}
