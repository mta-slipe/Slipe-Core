using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Slipe.Client.IO
{
    /// <summary>
    /// Class representing the cursor of the local player
    /// </summary>
    public class Cursor
    {
        /// <summary>
        /// Get and set the screen position of the cursor
        /// </summary>
        public static Vector2 Position
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

        /// <summary>
        /// Set the visibility and whether or not controls should be disabled
        /// </summary>
        public static bool SetVisible(bool visible, bool toggleControls = true)
        {
            return MtaClient.ShowCursor(visible, toggleControls);
        }
    }
}
