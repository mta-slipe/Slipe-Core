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
    /// Represents a Cegui scroll pane
    /// </summary>
    [DefaultElementClass("gui-scrollpane")]
    public class ScrollPane : GuiElement
    {
        #region Properties

        /// <summary>
        /// Get and set the horizontal scroll position (0-100)
        /// </summary>
        public float HorizontalScrollPosition
        {
            get
            {
                return MtaClient.GuiScrollPaneGetHorizontalScrollPosition(element);
            }
            set
            {
                MtaClient.GuiScrollPaneSetHorizontalScrollPosition(element, value);
            }
        }

        /// <summary>
        /// Get and set the vertical scroll position (0-100)
        /// </summary>
        public float VerticalScrollPosition
        {
            get
            {
                return MtaClient.GuiScrollPaneGetVerticalScrollPosition(element);
            }
            set
            {
                MtaClient.GuiScrollPaneSetVerticalScrollPosition(element, value);
            }
        }

        #endregion

        #region Constructors
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DefaultElementConstructor]
        public ScrollPane(MtaElement element) : base(element)
        {

        }

        /// <summary>
        /// Create a progress bar
        /// </summary>
        public ScrollPane(Vector2 position, Vector2 dimensions, bool relative = false, GuiElement parent = null)
            : this(MtaClient.GuiCreateScrollPane(position.X, position.Y, dimensions.X, dimensions.Y, relative, parent?.MTAElement)) { }
        #endregion

        /// <summary>
        /// Set if horizontal/vertical scrollbars should be used
        /// </summary>
        public bool UseScrollBars(bool horizontal, bool vertical)
        {
            return MtaClient.GuiScrollPaneSetScrollBars(element, horizontal, vertical);
        }
    }
}
