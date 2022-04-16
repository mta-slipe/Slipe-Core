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
    /// Represents a Cegui window
    /// </summary>
    [DefaultElementClass(ElementType.GuiWindow)]
    public class Window : GuiElement
    {
        #region Properties

        /// <summary>
        /// Get and set if the window is movable
        /// </summary>
        public bool Movable
        {
            get
            {
                return MtaClient.GuiWindowIsMovable(element);
            }
            set
            {
                MtaClient.GuiWindowSetMovable(element, value);
            }
        }

        /// <summary>
        /// Get and set if the window is sizable
        /// </summary>
        public bool Sizable
        {
            get
            {
                return MtaClient.GuiWindowIsSizable(element);
            }
            set
            {
                MtaClient.GuiWindowSetSizable(element, value);
            }
        }

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Window(MtaElement element) : base(element)
        {

        }

        /// <summary>
        /// Create a window
        /// </summary>
        public Window(Vector2 position, Vector2 dimensions, string title, bool relative = false)
            : this(MtaClient.GuiCreateWindow(position.X, position.Y, dimensions.X, dimensions.Y, title, relative)) { }

        #endregion
    }
}
