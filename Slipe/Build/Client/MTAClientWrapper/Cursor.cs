using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTAClientWrapper
{
    public class Cursor
    {
        public static bool IsVisible()
        {
            return Client.IsCursorShowing();
        }

        public static bool SetVisible(bool visible, bool toggleControls = true)
        {
            return Client.ShowCursor(visible, toggleControls);
        }
    }
}
