using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.Shared.Elements;
using SlipeLua.MtaDefinitions;
using System.Numerics;
using System.ComponentModel;

namespace SlipeLua.Client.Gui
{
    /// <summary>
    /// Represents a Cegui progress bar
    /// </summary>
    [DefaultElementClass(ElementType.GuiProgressBar)]
    public class ProgressBar : GuiElement
    {
        /// <summary>
        /// Get and set the progress (0-100)
        /// </summary>
        public float Progress
        {
            get
            {
                return MtaClient.GuiProgressBarGetProgress(element);
            }
            set
            {
                MtaClient.GuiProgressBarSetProgress(element, value);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public ProgressBar(MtaElement element) : base(element)
        {

        }

        /// <summary>
        /// Create a progress bar
        /// </summary>
        public ProgressBar(Vector2 position, Vector2 dimensions, bool relative = false, GuiElement parent = null)
            : this(MtaClient.GuiCreateProgressBar(position.X, position.Y, dimensions.X, dimensions.Y, relative, parent?.MTAElement)) { }
    }
}
