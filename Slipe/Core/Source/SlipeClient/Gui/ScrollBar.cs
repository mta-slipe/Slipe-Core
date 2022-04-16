﻿using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.Shared.Elements;
using SlipeLua.MtaDefinitions;
using System.Numerics;
using System.ComponentModel;
using SlipeLua.Client.Gui.Events;

namespace SlipeLua.Client.Gui
{
    /// <summary>
    /// Represents a Cegui scroll bar
    /// </summary>
    [DefaultElementClass(ElementType.GuiScrollBar)]
    public class ScrollBar : GuiElement
    {
        /// <summary>
        /// Get and set the position of this scroll bar (0-100)
        /// </summary>
        public float ScrollPosition
        {
            get
            {
                return MtaClient.GuiScrollBarGetScrollPosition(element);
            }
            set
            {
                MtaClient.GuiScrollBarSetScrollPosition(element, value);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public ScrollBar(MtaElement element) : base(element)
        {

        }

        /// <summary>
        /// Create a scroll bar
        /// </summary>
        public ScrollBar(Vector2 position, Vector2 dimensions, bool horizontal, bool relative = false, GuiElement parent = null)
            : this(MtaClient.GuiCreateScrollBar(position.X, position.Y, dimensions.X, dimensions.Y, horizontal, relative, parent?.MTAElement)) { }

        #region Events

        #pragma warning disable 67

        public delegate void OnScrollHandler(ScrollBar source, OnScrollEventArgs eventArgs);
        public event OnScrollHandler OnScroll;

        #pragma warning restore 67

        #endregion
    }
}
