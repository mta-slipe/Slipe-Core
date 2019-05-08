using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Elements;
using Slipe.MtaDefinitions;
using System.Numerics;
using System.ComponentModel;

namespace Slipe.Client.Gui
{
    /// <summary>
    /// Represents a static Cegui image
    /// </summary>
    [DefaultElementClass(ElementType.GuiStaticImage)]
    public class StaticImage : GuiElement
    {
        /// <summary>
        /// Get the native dimensions of this image
        /// </summary>
        Vector2 NativeSize
        {
            get
            {
                Tuple<int, int> r = MtaClient.GuiStaticImageGetNativeSize(element);
                return new Vector2(r.Item1, r.Item2);
            }
        }

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public StaticImage(MtaElement element) : base(element)
        {

        }

        /// <summary>
        /// Create a static image
        /// </summary>
        public StaticImage(Vector2 position, Vector2 dimensions, string filePath, bool relative = false, GuiElement parent = null)
            : this(MtaClient.GuiCreateStaticImage(position.X, position.Y, dimensions.X, dimensions.Y, filePath, relative, parent?.MTAElement)) { }
        #endregion

        /// <summary>
        /// Load a new image from a file path
        /// </summary>
        public bool LoadImage(string filePath)
        {
            return MtaClient.GuiStaticImageLoadImage(element, filePath);
        }

    }
}
