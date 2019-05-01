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
    /// Represents a multi-line gui edit box
    /// </summary>
    [DefaultElementClass("gui-memo")]
    public class Memo : EditableGuiElement
    {
        #region Properties

        /// <summary>
        /// Get and set the caret position within the memo box
        /// </summary>
        public int CarretIndex
        {
            get
            {
                return MtaClient.GuiMemoGetCaretIndex(element);
            }
            set
            {
                MtaClient.GuiMemoSetCaretIndex(element, value);
            }
        }

        /// <summary>
        /// Get and set the scroll position (0-100)
        /// </summary>
        public float VerticalScrollPosition
        {
            get
            {
                return MtaClient.GuiMemoGetVerticalScrollPosition(element);
            }
            set
            {
                MtaClient.GuiMemoSetVerticalScrollPosition(element, value);
            }
        }

        /// <summary>
        /// Get and set if this memo is read-only
        /// </summary>
        public bool ReadOnly
        {
            get
            {
                return MtaClient.GuiMemoIsReadOnly(element);
            }
            set
            {
                MtaClient.GuiMemoSetReadOnly(element, value);
            }
        }

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Memo(MtaElement element) : base(element)
        {

        }

        /// <summary>
        /// Create a new memo
        /// </summary>
        public Memo(Vector2 position, Vector2 dimensions, string defaultText, bool relative = false, GuiElement parent = null)
            : this (MtaClient.GuiCreateMemo(position.X, position.Y, dimensions.X, dimensions.Y, defaultText, relative, parent?.MTAElement)) { }

        #endregion
    }
}
