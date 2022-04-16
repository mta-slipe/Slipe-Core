using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;

namespace SlipeLua.Client.Gui
{
    /// <summary>
    /// Represents an item for a Cegui combo box
    /// </summary>
    public class ComboBoxItem
    {
        private ComboBox comboBox;
        
        /// <summary>
        /// Get the ID of this item in the combo box
        /// </summary>
        public int ID { get; }

        /// <summary>
        /// Get and set the text of this combo box item
        /// </summary>
        public string Content
        {
            get
            {
                return MtaClient.GuiComboBoxGetItemText(comboBox.MTAElement, ID);
            }
            set
            {
                MtaClient.GuiComboBoxSetItemText(comboBox.MTAElement, ID, value);
            }
        }

        /// <summary>
        /// Create a combo box item assigned to a combo box
        /// </summary>
        public ComboBoxItem(string content, ComboBox comboBox)
        {
            this.ID = MtaClient.GuiComboBoxAddItem(comboBox.MTAElement, content);
            this.comboBox = comboBox;
        }
    }
}
