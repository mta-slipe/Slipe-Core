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
    /// A Cegui single line text field
    /// </summary>
    public class Edit : GuiElement
    {
        #region Properties
        /// <summary>
        /// Get and set the car position within the editbox
        /// </summary>
        public int CaretIndex
        {
            get
            {
                return MtaClient.GuiEditGetCaretIndex(element);
            }
            set
            {
                MtaClient.GuiEditSetCaretIndex(element, value);
            }
        }

        /// <summary>
        /// Get and set the max text length that can be typed within this editbox
        /// </summary>
        public int MaxLength
        {
            get
            {
                return MtaClient.GuiEditGetMaxLength(element);
            }
            set
            {
                MtaClient.GuiEditSetMaxLength(element, value);
            }
        }

        /// <summary>
        /// Get and set if this edit is masked (password input)
        /// </summary>
        public bool Masked
        {
            get
            {
                return MtaClient.GuiEditIsMasked(element);
            }
            set
            {
                MtaClient.GuiEditSetMasked(element, value);
            }
        }

        /// <summary>
        /// Get and set if this editbox is read-only
        /// </summary>
        public bool ReadOnly
        {
            get
            {
                return MtaClient.GuiEditIsReadOnly(element);
            }
            set
            {
                MtaClient.GuiEditSetReadOnly(element, value);
            }
        }

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Edit(MtaElement element) : base(element)
        {

        }

        /// <summary>
        /// Create a new edit
        /// </summary>
        public Edit(Vector2 position, Vector2 dimensions, string defaultContent, bool relative = false, GuiElement parent = null, bool masked = false, int maxLength = 128)
        {
            element = MtaClient.GuiCreateEdit(position.X, position.Y, dimensions.X, dimensions.Y, defaultContent, relative, parent?.MTAElement);
            isRelative = relative;
            ElementManager.Instance.RegisterElement(this);
            Masked = masked;
            MaxLength = maxLength;
        }
        #endregion
    }
}
