using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Elements;
using System.ComponentModel;
using System.Numerics;

namespace Slipe.Client.Gui
{
    public abstract class GuiElement : Element
    {
        #region Properties

        /// <summary>
        /// Get and set if this GUI element is visible
        /// </summary>
        public bool Visible
        {
            get
            {
                return MtaClient.GuiGetVisible(element);
            }
            set
            {
                MtaClient.GuiSetVisible(element, value);
            }
        }

        /// <summary>
        /// Get and set the alpha of this GUI element
        /// </summary>
        public float Alpha
        {
            get
            {
                return MtaClient.GuiGetAlpha(element);
            }
            set
            {
                MtaClient.GuiSetAlpha(element, value);
            }
        }

        /// <summary>
        /// Get and set if this element is enabled
        /// </summary>
        public bool Enabled
        {
            get
            {
                return MtaClient.GuiGetEnabled(element);
            }
            set
            {
                MtaClient.GuiSetEnabled(element, value);
            }
        }

        /// <summary>
        /// Get and set the standard font of this element
        /// </summary>
        public StandardGuiFont StandardFont
        {
            get
            {
                (string s, _) = MtaClient.GuiGetFont(element);
                return (StandardGuiFont) Enum.Parse(typeof(StandardGuiFont), s.Replace("-", "_"), true);
            }
            set
            {
                MtaClient.GuiSetFont(element, value.ToString().ToLower().Replace("_", "-"));
            }
        }

        /// <summary>
        /// Get and set the custom font of this element
        /// </summary>
        public GuiFont CustomFont
        {
            get
            {
                (_, MtaElement e) = MtaClient.GuiGetFont(element);
                return (GuiFont)ElementManager.Instance.GetElement(e);
            }
            set
            {
                MtaClient.GuiSetFont(element, value.MTAElement);
            }
        }

        /// <summary>
        /// Get and set the absolute position of this element on the screen
        /// </summary>
        public Vector2 Position
        {
            get
            {
                (float x, float y) = MtaClient.GuiGetPosition(element, false);
                return new Vector2(x, y);
            }
            set
            {
                MtaClient.GuiSetPosition(element, value.X, value.Y, false);
            }
        }

        /// <summary>
        /// Get and set the relative position of this element to its parent
        /// </summary>
        public Vector2 RelativePosition
        {
            get
            {
                (float x, float y) = MtaClient.GuiGetPosition(element, true);
                return new Vector2(x, y);
            }
            set
            {
                MtaClient.GuiSetPosition(element, value.X, value.Y, true);
            }
        }

        /// <summary>
        /// Get and set the absolute size of this element on the screen
        /// </summary>
        public Vector2 Size
        {
            get
            {
                (float x, float y) = MtaClient.GuiGetSize(element, false);
                return new Vector2(x, y);
            }
            set
            {
                MtaClient.GuiSetSize(element, value.X, value.Y, false);
            }
        }

        /// <summary>
        /// Get and set the relative size of this element to its parent
        /// </summary>
        public Vector2 RelativeSize
        {
            get
            {
                (float x, float y) = MtaClient.GuiGetSize(element, true);
                return new Vector2(x, y);
            }
            set
            {
                MtaClient.GuiSetSize(element, value.X, value.Y, true);
            }
        }

        /// <summary>
        /// Get and set the text value
        /// </summary>
        public string Content
        {
            get
            {
                return MtaClient.GuiGetText(element);
            }
            set
            {
                MtaClient.GuiSetText(element, value);
            }
        }

        /// <summary>
        /// Get if this Gui item is created relatively to a parent
        /// </summary>
        protected bool isRelative;
        public bool IsRelative
        {
            get
            {
                return isRelative;
            }            
        }

        #endregion

        #region Constructors

        public GuiElement()
        {

        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public GuiElement(MtaElement element) : base(element)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// This function brings a Gui element on top of others.
        /// </summary>
        public bool BringToFront()
        {
            return MtaClient.GuiBringToFront(element);
        }

        /// <summary>
        /// This function moves a GUI element to the very back of all other GUI elements.
        /// </summary>
        public bool MoveToBack()
        {
            return MtaClient.GuiMoveToBack(element);
        }

        /// <summary>
        /// Blur this Gui Element
        /// </summary>
        public bool Blur()
        {
            return MtaClient.GuiBlur(element);
        }

        /// <summary>
        /// Focus on this Gui Element
        /// </summary>
        public bool Focus()
        {
            return MtaClient.GuiFocus(element);
        }

        /// <summary>
        /// Set a Cegui property
        /// </summary>
        public bool SetProperty(string property, string value)
        {
            return MtaClient.GuiSetProperty(element, property, value);
        }

        /// <summary>
        /// Get a Cegui property
        /// </summary>
        public string GetProperty(string property)
        {
            return MtaClient.GuiGetProperty(element, property);
        }

        #endregion
    }
}
