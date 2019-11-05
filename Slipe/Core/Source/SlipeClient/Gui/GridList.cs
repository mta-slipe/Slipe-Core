using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Elements;
using Slipe.MtaDefinitions;
using System.Numerics;
using System.ComponentModel;
using Slipe.Client.IO;

namespace Slipe.Client.Gui
{
    /// <summary>
    /// Represents a Cegui gridlist
    /// </summary>
    [DefaultElementClass(ElementType.GuiGridList)]
    public class GridList : GuiElement
    {
        private Dictionary<int, GridColumn> columns;
        private Dictionary<int, GridRow> rows;

        #region Properties

        /// <summary>
        /// Get the amount of columns
        /// </summary>
        public int ColumnCount
        {
            get
            {
                return MtaClient.GuiGridListGetColumnCount(element);
            }
        }

        /// <summary>
        /// Get the amount of rows
        /// </summary>
        public int RowCount
        {
            get
            {
                return MtaClient.GuiGridListGetRowCount(element);
            }
        }

        /// <summary>
        /// Get the amount of selected items, returns null if nothing is selected.
        /// </summary>
        public int SelectedCount
        {
            get
            {
                return MtaClient.GuiGridListGetSelectedCount(element);
            }
        }

        public GridItem SelectedItem
        {
            get
            {
                Tuple<int, int> item = MtaClient.GuiGridListGetSelectedItem(element);
                if (item.Item1 == -1 || item.Item2 == -1)
                {
                    return null;
                }
                return new GridItem(columns[item.Item2], rows[item.Item1], this);
            }
            set
            {
                MtaClient.GuiGridListSetSelectedItem(element, value.Row.ID, value.Column.ID, true);
            }
        }

        /// <summary>
        /// Get an array of all the selected items
        /// </summary>
        public GridItem[] SelectedItems
        {
            get
            {
                dynamic[] items = MtaShared.GetArrayFromTable(MtaClient.GuiGridListGetSelectedItems(element), "dynamic");
                GridItem[] result = new GridItem[items.Length];
                for (int i = 0; i < items.Length; i++)
                {
                    dynamic item = items[i];
                    Dictionary<string, int> itemSet = MtaShared.GetDictionaryFromTable(item, "System.String", "System.Int32");
                    GridColumn column = columns[itemSet["column"]];
                    GridRow row = rows[itemSet["row"]];
                    result[i] = new GridItem(column, row, this);
                }
                return result;
            }
        }

        /// <summary>
        /// Set the selection mode of this gridlist
        /// </summary>
        public SelectionMode SelectionMode
        {
            get
            {
                return (SelectionMode) MtaClient.GuiGridListGetSelectionMode(element);
            }
            set
            {
                MtaClient.GuiGridListSetSelectionMode(element, (int)value);
            }
        }

        /// <summary>
        /// Get and set the horizontal scroll position (0-100)
        /// </summary>
        public float HorizontalScrollPosition
        {
            get
            {
                return MtaClient.GuiGridListGetHorizontalScrollPosition(element);
            }
            set
            {
                MtaClient.GuiGridListSetHorizontalScrollPosition(element, value);
            }
        }

        /// <summary>
        /// Get and set the vertical scroll position (0-100)
        /// </summary>
        public float VerticalScrollPosition
        {
            get
            {
                return MtaClient.GuiGridListGetVerticalScrollPosition(element);
            }
            set
            {
                MtaClient.GuiGridListSetVerticalScrollPosition(element, value);
            }
        }

        /// <summary>
        /// Get and set if this gridlist is sortable
        /// </summary>
        public bool SortingEnabled
        {
            get
            {
                return MtaClient.GuiGridListIsSortingEnabled(element);
            }
            set
            {
                MtaClient.GuiGridListSetSortingEnabled(element, value);
            }
        }

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public GridList(MtaElement element) : base(element)
        {
            columns = new Dictionary<int, GridColumn>();
            rows = new Dictionary<int, GridRow>();
        }

        /// <summary>
        /// Create a new gridlist
        /// </summary>
        public GridList(Vector2 position, Vector2 dimensions, bool relative = false, GuiElement parent = null)
            : this(MtaClient.GuiCreateGridList(position.X, position.Y, dimensions.X, dimensions.Y, relative, parent?.MTAElement)) { }

        #endregion

        #region Methods

        /// <summary>
        /// Get a grid item from a column and row
        /// </summary>
        public GridItem GetItem(GridColumn column, GridRow row)
        {
            return new GridItem(column, row, this);
        }

        /// <summary>
        /// Add a new column to this gridlist
        /// </summary>
        public GridColumn AddColumn(string title, float width)
        {
            GridColumn column = new GridColumn(title, width, this);
            columns.Add(column.ID, column);
            return column;
        }

        /// <summary>
        /// Remove a grid column
        /// </summary>
        public bool RemoveColumn(GridColumn column)
        {
            if(MtaClient.GuiGridListRemoveColumn(element, column.ID))
            {
                columns.Remove(column.ID);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Add a new row to this gridlist
        /// </summary>
        public GridRow AddRow()
        {
            GridRow row = new GridRow(this);
            rows.Add(row.ID, row);
            return row;
        }

        /// <summary>
        /// Create a new row after an existing row
        /// </summary>
        public GridRow AddRowAfter(GridRow row)
        {
            GridRow newRow = new GridRow(this, row.ID);
            rows.Add(newRow.ID, newRow);
            return newRow;
        }

        /// <summary>
        /// Create a new row at the top of the list
        /// </summary>
        public GridRow AddTopRow()
        {
            GridRow row = new GridRow(this, -1);
            rows.Add(row.ID, row);
            return row;
        }

        /// <summary>
        /// Remove a grid row
        /// </summary>
        public bool RemoveRow(GridRow row)
        {
            if (MtaClient.GuiGridListRemoveRow(element, row.ID))
            {
                rows.Remove(row.ID);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Clear this gridlist
        /// </summary>
        public bool Clear()
        {
            return MtaClient.GuiGridListClear(element);
        }

        /// <summary>
        /// Change if horizontal/vertical scrollbars should be used
        /// </summary>
        public bool UseScrollBars(bool horizontal, bool vertical)
        {
            return MtaClient.GuiGridListSetScrollBars(element, horizontal, vertical);
        }

        #endregion
    }
}
