using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client
{
    public class Cursor
    {
        public static bool IsVisible()
        {
            return MTAClient.IsCursorShowing();
        }

        public static bool SetVisible(bool visible, bool toggleControls = true)
        {
            return MTAClient.ShowCursor(visible, toggleControls);
        }
    }
}
