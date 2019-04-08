using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.IO
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
            return MtaClient.IsCursorShowing();
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
