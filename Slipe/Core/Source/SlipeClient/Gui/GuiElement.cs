using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Elements;
using System.ComponentModel;

namespace Slipe.Client.Gui
{
    public abstract class GUIElement : Element
    {
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

        #region Constructors

        public GUIElement()
        {

        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public GUIElement(MtaElement element) : base(element)
        {

        }

        #endregion
    }
}
