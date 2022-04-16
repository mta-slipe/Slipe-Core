using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SlipeLua.Client.Gui.Events;
using SlipeLua.MtaDefinitions;

namespace SlipeLua.Client.Gui
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

        #pragma warning disable 67

        public delegate void OnChangedHandler(EditableGuiElement source, OnChangedEventArgs eventArgs);
        public event OnChangedHandler OnChanged;

        #pragma warning restore 67

        #endregion
    }
}
