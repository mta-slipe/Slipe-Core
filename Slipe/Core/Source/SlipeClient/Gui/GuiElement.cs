using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Elements;
using System.ComponentModel;
using System.Numerics;
using Slipe.Shared.IO;

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

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DefaultElementConstructor]
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

        #region Events

        #pragma warning disable 67

        public delegate void OnBlurHandler();
        public event OnBlurHandler OnBlur;

        public delegate void OnFocusHandler();
        public event OnFocusHandler OnFocus;

        public delegate void OnClickHandler(MouseButton button, MouseButtonState buttonState, Vector2 mousePosition);
        public event OnClickHandler OnClick;

        public delegate void OnDoubleClickHandler(MouseButton button, MouseButtonState buttonState, Vector2 mousePosition);
        public event OnDoubleClickHandler OnDoubleClick;

        public delegate void OnMouseDownHandler(MouseButton button, Vector2 mousePosition);
        public event OnMouseDownHandler OnMouseDown;

        public delegate void OnMouseUpHandler(MouseButton button, Vector2 mousePosition);
        public event OnMouseUpHandler OnMouseUp;

        public delegate void OnMoveHandler();
        public event OnMoveHandler OnMove;

        public delegate void OnResizeHandler();
        public event OnResizeHandler OnResize;

        public delegate void OnMouseEnterHandler(Vector2 mousePosition, GuiElement previousHoverGuiElement);
        public event OnMouseEnterHandler OnMouseEnter;

        public delegate void OnMouseLeaveHandler(Vector2 mousePosition, GuiElement nextHoverGuiElement);
        public event OnMouseLeaveHandler OnMouseLeave;

        public delegate void OnMouseMoveHandler(Vector2 mousePosition);
        public event OnMouseMoveHandler OnMouseMove;

        public delegate void OnMouseWheelHandler(MouseWheelState upOrDown);
        public event OnMouseWheelHandler OnMouseWheel;

        #pragma warning restore 67

        #endregion
    }
}
