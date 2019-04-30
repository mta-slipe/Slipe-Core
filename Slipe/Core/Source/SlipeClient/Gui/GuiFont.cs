using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;

namespace Slipe.Client.Gui
{
    /// <summary>
    /// Represents a custom Gui Font
    /// </summary>
    public class GuiFont : Element
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DefaultElementConstructor]
        public GuiFont(MtaElement element) : base(element)
        {

        }

        public GuiFont(string filePath, int size = 9)
            : this(MtaClient.GuiCreateFont(filePath, size)) { }
    }
}
