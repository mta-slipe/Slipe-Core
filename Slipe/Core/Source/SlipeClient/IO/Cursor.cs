using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.Shared.IO;
using Slipe.Shared.Elements;
using Slipe.Client.Elements;

namespace Slipe.Client.IO
{
    /// <summary>
    /// Class representing the cursor of the local player
    /// </summary>
    public class Cursor
    {
        protected static Cursor instance;

        public static Cursor Instance
        {
            get
            {
                instance = instance ?? new Cursor();
                return instance;
            }
        }


        #region Properties

        /// <summary>
        /// Get and set the screen position of the cursor
        /// </summary>
        public Vector2 Position
        {
            get
            {
                Tuple<float, float, float, float, float> r = MtaClient.GetCursorPosition();
                return new Vector2(r.Item1, r.Item2);
            }
            set
            {
                MtaClient.SetCursorPosition((int) value.X, (int) value.Y);
            }
        }

        /// <summary>
        /// Get the world position of the cursor
        /// </summary>
        public Vector3 WorldPosition
        {
            get
            {
                Tuple<float, float, float, float, float> r = MtaClient.GetCursorPosition();
                return new Vector3(r.Item3, r.Item4, r.Item5);
            }
        }

        /// <summary>
        /// Get and set the opacity of the cursor (0-255)
        /// </summary>
        public int Alpha
        {
            get
            {
                return MtaClient.GetCursorAlpha();
            }
            set
            {
                MtaClient.SetCursorAlpha(value);
            }
        }

        /// <summary>
        /// Get the type of the current cursor image.
        /// </summary>
        public string Type
        {
            get
            {
                return MtaClient.GuiGetCursorType();
            }
        }

        /// <summary>
        /// Get the visibility of the cursor
        /// </summary>
        public bool Visible
        {
            get
            {
                return MtaClient.IsCursorShowing();
            }            
        }

        #endregion

        private Cursor()
        {
            RootElement.OnClick += (MouseButton mouseButton, MouseButtonState buttonState, Vector2 screenPosition, Vector3 worldPosition, PhysicalElement clickedElement) => { OnClick?.Invoke(mouseButton, buttonState, screenPosition, worldPosition, clickedElement); };
            RootElement.OnDoubleClick += (MouseButton mouseButton, Vector2 screenPosition, Vector3 worldPosition, PhysicalElement clickedElement) => { OnDoubleClick?.Invoke(mouseButton, screenPosition, worldPosition, clickedElement); };
            RootElement.OnCursorMove += (Vector2 relativePosition, Vector2 absolutePosition, Vector3 worldPosition) => { OnMove?.Invoke(relativePosition, absolutePosition, worldPosition); };
        }

        /// <summary>
        /// Set the visibility and whether or not controls should be disabled
        /// </summary>
        public bool SetVisible(bool visible, bool toggleControls = true)
        {
            return MtaClient.ShowCursor(visible, toggleControls);
        }

        #region Events

        public delegate void OnClickHandler(MouseButton mouseButton, MouseButtonState buttonState, Vector2 screenPosition, Vector3 worldPosition, PhysicalElement clickedElement);
        public static event OnClickHandler OnClick;

        public delegate void OnDoubleClickHandler(MouseButton mouseButton, Vector2 screenPosition, Vector3 worldPosition, PhysicalElement clickedElement);
        public static event OnDoubleClickHandler OnDoubleClick;

        public delegate void OnMoveHandler(Vector2 relativePosition, Vector2 absolutePosition, Vector3 worldPosition);
        public static event OnMoveHandler OnMove;

        #endregion
    }
}
