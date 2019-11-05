using System;
using Slipe.MtaDefinitions;
using Slipe.Shared.Utilities;

namespace Slipe.Client.Gui
{
    /// <summary>
    /// Represents a single item in a Gui gridlist
    /// </summary>
    public class GridItem
    {
        private GridList glist;

        #region Properties

        /// <summary>
        /// The column of this item
        /// </summary>
        public GridColumn Column { get; }

        /// <summary>
        /// The row of this item
        /// </summary>
        public GridRow Row { get; }

        /// <summary>
        /// Get and set the color of this item
        /// </summary>
        public Color Color
        {
            get
            {
                Tuple<int, int, int, int> color = MtaClient.GuiGridListGetItemColor(glist.MTAElement, Row.ID, Column.ID);
                return new Color((byte)color.Item1, (byte)color.Item2, (byte)color.Item3, (byte)color.Item4);
            }
            set
            {
                MtaClient.GuiGridListSetItemColor(glist.MTAElement, Row.ID, Column.ID, value.R, value.G, value.B, value.A);
            }
        }

        /// <summary>
        /// Get and set the text of this item
        /// </summary>
        public string Content
        {
            get
            {
                return MtaClient.GuiGridListGetItemText(glist.MTAElement, Row.ID, Column.ID);
            }
            set
            {
                MtaClient.GuiGridListSetItemText(glist.MTAElement, Row.ID, Column.ID, value, false, false);
            }
        }

        /// <summary>
        /// Get and set the data of this list
        /// </summary>
        public dynamic Data
        {
            get
            {
                if (string.IsNullOrEmpty(Content))
                {
                    Content = "";
                }
                return MtaClient.GuiGridListGetItemData(glist.MTAElement, Row.ID, Column.ID);
            }
            set
            {
                if(string.IsNullOrEmpty(Content))
                {
                    Content = "";
                }
                MtaClient.GuiGridListSetItemData(glist.MTAElement, Row.ID, Column.ID, value);
            }
        }

        #endregion

        /// <summary>
        /// Create a new item handle
        /// </summary>
        public GridItem(GridColumn column, GridRow row, GridList gridList)
        {
            Column = column;
            Row = row;
            glist = gridList;
        }

        /// <summary>
        /// Set this item as a section while setting the text
        /// </summary>
        public bool SetSection(string content)
        {
            return MtaClient.GuiGridListSetItemText(glist.MTAElement, Row.ID, Column.ID, content, true, false);
        }

    }
}
