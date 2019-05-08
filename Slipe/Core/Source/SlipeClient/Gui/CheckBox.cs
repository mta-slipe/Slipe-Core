using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Elements;
using Slipe.MtaDefinitions;
using System.Numerics;
using System.ComponentModel;

namespace Slipe.Client.Gui
{
    /// <summary>
    /// A Cegui checkbox
    /// </summary>
    [DefaultElementClass(ElementType.GuiCheckBox)]
    public class CheckBox : GuiElement
    {
        /// <summary>
        /// Get or set if this checkbox is selected
        /// </summary>
        public bool Selected
        {
            get
            {
                return MtaClient.GuiCheckBoxGetSelected(element);
            }
            set
            {
                MtaClient.GuiCheckBoxSetSelected(element, value);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public CheckBox(MtaElement element) : base(element)
        {

        }

        /// <summary>
        /// Create a new checkbox
        /// </summary>
        public CheckBox(Vector2 position, Vector2 dimensions, string content, bool selected = false, bool relative = false, GuiElement parent = null)
            : this(MtaClient.GuiCreateCheckBox(position.X, position.Y, dimensions.X, dimensions.Y, content, selected, relative, parent?.MTAElement)) { }
    }
}
