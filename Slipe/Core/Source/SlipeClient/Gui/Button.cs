﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SlipeLua.Shared.Elements;
using SlipeLua.MtaDefinitions;
using System.Numerics;

namespace SlipeLua.Client.Gui
{
    /// <summary>
    /// Represents a Cegui button
    /// </summary>
    [DefaultElementClass(ElementType.GuiButton)]
    public class Button : GuiElement
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Button(MtaElement element) : base(element)
        {

        }

        /// <summary>
        /// Create a new button
        /// </summary>
        public Button(Vector2 position, Vector2 dimensions, string content, bool relative = false, GuiElement parent = null)
            : this(MtaClient.GuiCreateButton(position.X, position.Y, dimensions.X, dimensions.Y, content, relative, parent?.MTAElement)) { }
    }
}
