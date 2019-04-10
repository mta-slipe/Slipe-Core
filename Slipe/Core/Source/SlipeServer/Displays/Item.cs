using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MtaDefinitions;
using Slipe.Shared.Utilities;

namespace Slipe.Server.Displays
{
    /// <summary>
    /// Represents a text label visible on a display
    /// </summary>
    public class Item
    {
        #region Properties
        public MtaElement ItemElement { get; }
        public Display Display { get; }

        /// <summary>
        /// Hide or show the text
        /// </summary>
        private bool visible;
        public bool Visible
        {
            get
            {
                return visible;
            }
            set
            {
                visible = value;
                if (visible)
                    MtaServer.TextDisplayAddText(Display.DisplayElement, ItemElement);
                else
                    MtaServer.TextDisplayRemoveText(Display.DisplayElement, ItemElement);
            }
        }

        /// <summary>
        /// Get and set the color of this item
        /// </summary>
        public Color Color
        {
            get
            {
                Tuple<int, int, int, int> c = MtaServer.TextItemGetColor(ItemElement);
                return new Color((byte)c.Item1, (byte)c.Item2, (byte)c.Item3, (byte)c.Item4);
            }
            set
            {
                MtaServer.TextItemSetColor(ItemElement, value.R, value.G, value.B, value.A);
            }
        }

        /// <summary>
        /// Get and set the screen position of this text item
        /// </summary>
        public Vector2 Position
        {
            get
            {
                Tuple<float, float> r = MtaServer.TextItemGetPosition(ItemElement);
                return new Vector2(r.Item1, r.Item2);
            }
            set
            {
                MtaServer.TextItemSetPosition(ItemElement, value.X, value.Y);
            }
        }

        /// <summary>
        /// Get and set the priority with which to update this text
        /// </summary>
        public Priority Priority
        {
            get
            {
                return (Priority)MtaServer.TextItemGetPriority(ItemElement);
            }
            set
            {
                MtaServer.TextItemSetPriority(ItemElement, value.ToString().ToLower());
            }
        }

        /// <summary>
        /// Get and set the scale of this text
        /// </summary>
        public float Scale
        {
            get
            {
                return MtaServer.TextItemGetScale(ItemElement);
            }
            set
            {
                MtaServer.TextItemSetScale(ItemElement, value);
            }
        }

        /// <summary>
        /// Get and set the text
        /// </summary>
        public string Content
        {
            get
            {
                return MtaServer.TextItemGetText(ItemElement);
            }
            set
            {
                MtaServer.TextItemSetText(ItemElement, value);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new text item
        /// </summary>
        public Item(Display display, string content, Vector2 position, Priority priority, Color color, float scale, HorizontalAlignment alignX, VerticalAlignment alignY, int shadowAlpha = 0)
        {
            Display = display;
            ItemElement = MtaServer.TextCreateTextItem(content, position.X, position.Y, priority.ToString().ToLower(), color.R, color.G, color.B, color.A, scale, alignX.ToString().ToLower(), alignY.ToString().ToLower(), shadowAlpha);
            MtaServer.TextDisplayAddText(display.DisplayElement, ItemElement);
            visible = true;
        }

        /// <summary>
        /// Create a new text item
        /// </summary>
        public Item(Display display, string content, Vector2 position, Priority priority, Color color, float scale = 1) : this(display, content, position, priority, color, scale, HorizontalAlignment.Left, VerticalAlignment.Top) { }

        /// <summary>
        /// Create a new text item
        /// </summary>
        public Item(Display display, string content, Vector2 position, Priority priority) : this(display, content, position, priority, Color.White) { }

        /// <summary>
        /// Create a new text item
        /// </summary>
        public Item(Display display, string content, Vector2 position) : this(display, content, position, Priority.Medium) { }

        #endregion

        public bool Destroy()
        {
            return MtaServer.TextDestroyTextItem(ItemElement);
        }
    }
}
