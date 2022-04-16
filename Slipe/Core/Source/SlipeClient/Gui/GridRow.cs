using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;

namespace SlipeLua.Client.Gui
{
    /// <summary>
    /// Represents a row in a grid list
    /// </summary>
    public class GridRow
    {
        private GridList glist;

        /// <summary>
        /// Get the ID of this column in the Grid
        /// </summary>
        public int ID { get; }

        /// <summary>
        /// Create a new row
        /// </summary>
        public GridRow(GridList gridList)
        {
            this.ID = MtaClient.GuiGridListAddRow(gridList.MTAElement, null, null);
            glist = gridList;
        }

        /// <summary>
        /// Create a new row after an existing row index
        /// </summary>
        public GridRow(GridList gridList, int index)
        {
            this.ID = MtaClient.GuiGridListInsertRowAfter(gridList.MTAElement, index);
            glist = gridList;
        }
    }
}
