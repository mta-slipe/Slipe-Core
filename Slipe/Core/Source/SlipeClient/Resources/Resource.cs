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
        private static Resource thisResource;
        public static Resource This
        {
            get
            {
                if (thisResource == null)
                    thisResource = ResourceManager.Instance.GetResource(MtaShared.GetThisResource());
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
                return ElementManager.Instance.GetElement(MtaClient.GetResourceGUIElement(MTAResource));
            }
        }

        #region Constructor

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Resource(MtaResource resource) : base(resource)
        {
            ResourceManager.Instance.RegisterResource(this);
        }

        #endregion

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
