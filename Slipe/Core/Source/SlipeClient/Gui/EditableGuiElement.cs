using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Slipe.MtaDefinitions;

namespace Slipe.Client.Gui
{
    /// <summary>
    /// Represents an editable Gui element
    /// </summary>
    public abstract class EditableGuiElement : GuiElement
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public EditableGuiElement(MtaElement element) : base(element)
        {

        }

        #region Events

        public delegate void OnChangedHandler();
        public event OnChangedHandler OnChanged;

        #endregion
    }
}
