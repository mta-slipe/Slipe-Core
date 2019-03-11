﻿using MTASharedWrapper;
using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTAClientWrapper
{
    public abstract class GUIElement: Element
    {
        public bool Visible
        {
            get
            {
                return Client.GuiGetVisible(element);
            }
            set
            {
                Client.GuiSetVisible(element, value);
            }
        }

        public new float Alpha
        {
            get
            {
                return Client.GuiGetAlpha(element);
            }
            set
            {
                Client.GuiSetAlpha(element, value);
            }
        }
    }
}
