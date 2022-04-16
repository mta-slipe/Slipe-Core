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
    /// Represents a Cegui radio button
    /// </summary>
    [DefaultElementClass(ElementType.GuiRadioButton)]
    public class RadioButton : GuiElement
    {
        /// <summary>
        /// Get and set if this button is selected
        /// </summary>
        public bool Selected
        {
            get
            {
                return MtaClient.GuiRadioButtonGetSelected(element);
            }
            set
            {
                MtaClient.GuiRadioButtonSetSelected(element, value);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public RadioButton(MtaElement element) : base(element)
        {

        }

        /// <summary>
        /// Create a radio button
        /// </summary>
        public RadioButton(Vector2 position, Vector2 dimensions, string content, bool relative = false, GuiElement parent = null)
            : this(MtaClient.GuiCreateRadioButton(position.X, position.Y, dimensions.X, dimensions.Y, content, relative, parent?.MTAElement)) { }
    }
}
