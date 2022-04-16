using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;

namespace SlipeLua.Client.Gui
{
    /// <summary>
    /// Represents a column in a grid list
    /// </summary>
    public class GridColumn
    {
        private GridList glist;

        /// <summary>
        /// Get the ID of this column in the Grid
        /// </summary>
        public int ID { get; }

        /// <summary>
        /// Get and set the title of this column
        /// </summary>
        public string Title
        {
            get
            {
                return MtaClient.GuiGridListGetColumnTitle(glist.MTAElement, ID);
            }
            set
            {
                MtaClient.GuiGridListSetColumnTitle(glist.MTAElement, ID, value);
            }
        }

        /// <summary>
        /// Get and set the width of this column in absolute screen pixels
        /// </summary>
        public float AbsoluteWidth
        {
            get
            {
                return MtaClient.GuiGridListGetColumnWidth(glist.MTAElement, ID, false);
            }
            set
            {
                MtaClient.GuiGridListSetColumnWidth(glist.MTAElement, ID, value, false);
            }
        }

        /// <summary>
        /// Get and set the width of this column relative to the parent Gui element
        /// </summary>
        public float RelativeWidth
        {
            get
            {
                return MtaClient.GuiGridListGetColumnWidth(glist.MTAElement, ID, true);
            }
            set
            {
                MtaClient.GuiGridListSetColumnWidth(glist.MTAElement, ID, value, true);
            }
        }

        /// <summary>
        /// Create a new column
        /// </summary>
        public GridColumn(string title, float width, GridList gridList)
        {
            this.ID = MtaClient.GuiGridListAddColumn(gridList.MTAElement, title, width);
            glist = gridList;
        }

        /// <summary>
        /// This allows you to automatically size a column to display everything in it correctly, with the most minimal width.
        /// </summary>
        public bool AutoSize()
        {
            return MtaClient.GuiGridListAutoSizeColumn(glist.MTAElement, ID);
        }

    }
}
