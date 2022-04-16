﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;

namespace SlipeLua.Client.Gui
{
    /// <summary>
    /// Represents a custom Gui Font
    /// </summary>
    public class GuiFont : Element
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public GuiFont(MtaElement element) : base(element)
        {

        }

        public GuiFont(string filePath, int size = 9)
            : this(MtaClient.GuiCreateFont(filePath, size)) { }
    }
}
