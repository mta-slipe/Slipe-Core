using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client
{
    /// <summary>
    /// Class representing the cursor of the local player
    /// </summary>
    public class Cursor
    {

        /// <summary>
        /// Get the visibility of the cursor
        /// </summary>
        public static bool IsVisible()
        {
            return MTAClient.IsCursorShowing();
        }

        /// <summary>
        /// Set the visibility and whether or not controls should be disabled
        /// </summary>
        public static bool SetVisible(bool visible, bool toggleControls = true)
        {
            return MTAClient.ShowCursor(visible, toggleControls);
        }
    }
}
