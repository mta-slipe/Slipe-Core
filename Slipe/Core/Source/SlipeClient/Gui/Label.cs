using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Elements;
using Slipe.MtaDefinitions;
using System.Numerics;
using System.ComponentModel;
using Slipe.Shared.Utilities;

namespace Slipe.Client.Gui
{
    /// <summary>
    /// Represents a Cegui label
    /// </summary>
    [DefaultElementClass(ElementType.GuiLabel)]
    public class Label : GuiElement
    {
        #region Properties

        /// <summary>
        /// Get and set the color of this label
        /// </summary>
        public Color Color
        {
            get
            {
                Tuple<int, int, int> c = MtaClient.GuiLabelGetColor(element);
                return new Color((byte)c.Item1, (byte)c.Item2, (byte)c.Item3);
            }
            set
            {
                MtaClient.GuiLabelSetColor(element, value.R, value.G, value.B);
            }
        }

        /// <summary>
        /// Get the font height
        /// </summary>
        public float FontHeight
        {
            get
            {
                return MtaClient.GuiLabelGetFontHeight(element);
            }
        }

        /// <summary>
        /// Get the width the label has with this text
        /// </summary>
        public float Extent
        {
            get
            {
                return MtaClient.GuiLabelGetTextExtent(element);
            }
        }

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Label(MtaElement element) : base(element)
        {

        }

        /// <summary>
        /// Create a label
        /// </summary>
        public Label(Vector2 position, Vector2 dimensions, string content, bool relative = false, GuiElement parent = null)
            : this(MtaClient.GuiCreateLabel(position.X, position.Y, dimensions.X, dimensions.Y, content, relative, parent?.MTAElement)) { }
        #endregion

        /// <summary>
        /// Set the horizontal alignment of text
        /// </summary>
        public bool SetHorizontalAlign(HorizontalAlign alignment, bool wordWrap = false)
        {
            return MtaClient.GuiLabelSetHorizontalAlign(element, alignment.ToString().ToLower(), wordWrap);
        }

        /// <summary>
        /// Set the vertical alignment of text
        /// </summary>
        public bool SetVerticalAlign(VerticalAlign alignment)
        {
            return MtaClient.GuiLabelSetVerticalAlign(element, alignment.ToString().ToLower());
        }
    }
}
