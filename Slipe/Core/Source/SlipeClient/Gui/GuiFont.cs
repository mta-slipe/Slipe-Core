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
        public GuiFont(MtaElement element) : base(element)
        {

        }

        public GuiFont(string filePath, int size = 9)
        {
            element = MtaClient.GuiCreateFont(filePath, size);
            ElementManager.Instance.RegisterElement(this);
        }
    }
}
