﻿using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.Shared.Elements;
using SlipeLua.MtaDefinitions;
using System.Numerics;
using System.ComponentModel;

namespace SlipeLua.Client.Gui
{
    /// <summary>
    /// Represents a Cegui tab panel
    /// </summary>
    [DefaultElementClass(ElementType.GuiTabPanel)]
    public class TabPanel : GuiElement
    {
        /// <summary>
        /// Get and set the selected tab
        /// </summary>
        public Tab Selected
        {
            get
            {
                return ElementManager.Instance.GetElement<Tab>(MtaClient.GuiGetSelectedTab(element));
            }
            set
            {
                MtaClient.GuiSetSelectedTab(element, value.MTAElement);
            }
        }

        #region Constructor

        [EditorBrowsable(EditorBrowsableState.Never)]
        public TabPanel(MtaElement element) : base(element)
        {

        }

        /// <summary>
        /// Create a tab panel
        /// </summary>
        public TabPanel(Vector2 position, Vector2 dimensions, bool relative = false, GuiElement parent = null)
            : this(MtaClient.GuiCreateTabPanel(position.X, position.Y, dimensions.X, dimensions.Y, relative, parent?.MTAElement)) { }

        #endregion
    }
}
