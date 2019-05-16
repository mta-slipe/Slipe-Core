using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Elements;
using Slipe.MtaDefinitions;
using System.Numerics;
using System.ComponentModel;
using Slipe.Client.Gui.Events;

namespace Slipe.Client.Gui
{
    /// <summary>
    /// Represents a Cegui combo box
    /// </summary>
    [DefaultElementClass(ElementType.GuiComboBox)]
    public class ComboBox : GuiElement
    {
        private Dictionary<int, ComboBoxItem> items;

        #region Properties

        /// <summary>
        /// The amount of items in this combo box
        /// </summary>
        public int ItemCount
        {
            get
            {
                return MtaClient.GuiComboBoxGetItemCount(element);
            }
        }

        /// <summary>
        /// Get or set if the combo box is open or not
        /// </summary>
        public bool Open
        {
            get
            {
                return MtaClient.GuiComboBoxIsOpen(element);
            }
            set
            {
                MtaClient.GuiComboBoxSetOpen(element, value);
            }
        }

        /// <summary>
        /// Get and set the selected item
        /// </summary>
        public ComboBoxItem Selected
        {
            get
            {
                return items[MtaClient.GuiComboBoxGetSelected(element)];
            }
            set
            {
                MtaClient.GuiComboBoxSetSelected(element, value.ID);
            }
        }

        #endregion

        #region Constructors
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ComboBox(MtaElement element) : base(element)
        {
            items = new Dictionary<int, ComboBoxItem>();
        }

        /// <summary>
        /// Create a new combo box
        /// </summary>
        public ComboBox(Vector2 position, Vector2 dimensions, string caption, bool relative = false, GuiElement parent = null)
            : this(MtaClient.GuiCreateComboBox(position.X, position.Y, dimensions.X, dimensions.Y, caption, relative, parent?.MTAElement)) { }
        #endregion

        /// <summary>
        /// Remove all items from this combo box
        /// </summary>
        public bool Clear()
        {
            return MtaClient.GuiComboBoxClear(element);
        }

        /// <summary>
        /// Add a new item
        /// </summary>
        public ComboBoxItem AddItem(string content)
        {
            ComboBoxItem item = new ComboBoxItem(content, this);
            items.Add(item.ID, item);
            return item;
        }

        /// <summary>
        /// Remove a specific item from the combo box
        /// </summary>
        public bool RemoveItem(ComboBoxItem item)
        {
            if(MtaClient.GuiComboBoxRemoveItem(element, item.ID))
            {
                items.Remove(item.ID);
                return true;
            }
            return false;
        }

        #region Events

        #pragma warning disable 67

        public delegate void OnAcceptedHandler(ComboBox source, OnAcceptedEventArgs eventArgs);
        public event OnAcceptedHandler OnAccepted;

        #pragma warning restore 67

        #endregion
    }
}
