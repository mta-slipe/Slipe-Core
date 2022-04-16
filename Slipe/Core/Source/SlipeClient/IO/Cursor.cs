using SlipeLua.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using SlipeLua.Shared.IO;
using SlipeLua.Shared.Elements;
using SlipeLua.Client.Elements;
using SlipeLua.Client.IO.Events;
using SlipeLua.Client.Rendering;

namespace SlipeLua.Client.IO
{
    /// <summary>
    /// Class representing the cursor of the local player
    /// </summary>
    public static class Cursor
    {
        #region Properties

        /// <summary>
        /// Get and set the screen position of the cursor as a relative float between 0 and 1
        /// </summary>
        public static Vector2 RelativePosition
        {
            get
            {
                Tuple<float, float, float, float, float> r = MtaClient.GetCursorPosition();
                return new Vector2(r.Item1, r.Item2);
            }
        }

        /// <summary>
        /// Get the absolute screen position of the cursor in pixel coordinates
        /// </summary>
        public static Vector2 Position
        {
            get
            {
                Tuple<float, float, float, float, float> r = MtaClient.GetCursorPosition();

                return new Vector2(r.Item1 * Renderer.ScreenSize.X, r.Item2 * Renderer.ScreenSize.Y);
            }
            set
            {
                MtaClient.SetCursorPosition((int) value.X, (int) value.Y);
            }
        }

        /// <summary>
        /// Get the world position of the cursor
        /// </summary>
        public static Vector3 WorldPosition
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
        public static int Alpha
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
        public static string Type
        {
            get
            {
                return MtaClient.GuiGetCursorType();
            }
        }

        /// <summary>
        /// Get the visibility of the cursor
        /// </summary>
        public static bool Visible
        {
            get
            {
                return MtaClient.IsCursorShowing();
            }            
        }

        #endregion

        /// <summary>
        /// Set the visibility and whether or not controls should be disabled
        /// </summary>
        public static bool SetVisible(bool visible, bool toggleControls = true)
        {
            return MtaClient.ShowCursor(visible, toggleControls);
        }

        #region Events

#pragma warning disable 67

        public delegate void OnClickHandler(RootElement source, OnClickEventArgs eventArgs);
        public static event OnClickHandler OnClick;

        public delegate void OnDoubleClickHandler(RootElement source, OnDoubleClickEventArgs eventArgs);
        public static event OnDoubleClickHandler OnDoubleClick;

        public delegate void OnMoveHandler(RootElement source, OnMoveEventArgs eventArgs);
        public static event OnMoveHandler OnMove;

#pragma warning enable 67

        #endregion
    }
}
