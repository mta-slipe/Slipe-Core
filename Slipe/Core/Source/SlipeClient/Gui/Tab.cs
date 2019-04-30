using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Elements;
using Slipe.MtaDefinitions;
using System.Numerics;
using System.ComponentModel;

namespace Slipe.Client.Gui
{
    /// <summary>
    /// Represents a Cegui tab (use with tab panel)
    /// </summary>
    [DefaultElementClass("gui-tab")]
    public class Tab : GuiElement
    {
        private TabPanel parentPanel;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DefaultElementConstructor]
        public Tab(MtaElement element) : base(element)
        {
            parentPanel = (TabPanel) ElementManager.Instance.GetElement(MtaShared.GetElementParent(element));
        }

        /// <summary>
        /// Create a tab
        /// </summary>
        public Tab(string title, TabPanel panel)
            : this(MtaClient.GuiCreateTab(title, panel.MTAElement)) { }

        /// <summary>
        /// Delete this tab
        /// </summary>
        public bool Delete()
        {
            return MtaClient.GuiDeleteTab(element, parentPanel.MTAElement);
        }

        #region Events

        #pragma warning disable 67

        public delegate void OnOpenHandler();
        public event OnOpenHandler OnOpen;

        #pragma warning restore 67

        #endregion
    }
}
