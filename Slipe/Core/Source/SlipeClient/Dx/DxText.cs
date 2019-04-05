using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;
using Slipe.Client.Enums;
using Slipe.Shared.Utilities;

namespace Slipe.Client.Dx
{
    /// <summary>
    /// Represents a drawable text line
    /// </summary>
    public class DxText : Dx2DObject, IDrawable
    {
        protected bool useCustomFont;
        protected Font customFont;
        protected StandardFontEnum standardFont;

        /// <summary>
        /// The text of this element
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Absolute coordinates of the bottom right bounding box
        /// </summary>
        public Vector2 BottomRight { get; set; }

        /// <summary>
        /// The X and Y scale of this text
        /// </summary>
        public Vector2 Scale { get; set; }

        /// <summary>
        /// The font of this text
        /// </summary>
        public Font CustomFont
        {
            get
            {
                return customFont;
            }
            set
            {
                customFont = value;
                useCustomFont = true;
            }
        }

        /// <summary>
        /// The default font of this text
        /// </summary>
        public StandardFontEnum StandardFont
        {
            get
            {
                return standardFont;
            }
            set
            {
                standardFont = value;
                useCustomFont = false;
            }
        }

        /// <summary>
        /// Where the text is horizontally aligned in the bounding box
        /// </summary>
        public HorizontalAlignEnum HorizontalAlignment { get; set; }

        /// <summary>
        /// Where the text is vertically aligned in the bounding box
        /// </summary>
        public VerticalAlignEnum VerticalAlignment { get; set; }

        /// <summary>
        /// The rotation of this text
        /// </summary>
        public float Rotation { get; set; }

        /// <summary>
        /// The origin of the rotation
        /// </summary>
        public Vector2 RotationOrigin { get; set; }

        /// <summary>
        /// A bool representing whether the rectangle can be positioned sub-pixel-ly.
        /// </summary>
        public bool SubPixelPositioning { get; set; }

        /// <summary>
        /// if set to true, the parts of the text that don't fit within the bounding box will be cut off.
        /// </summary>
        public bool Clip { get; set; }

        /// <summary>
        /// if set to true, the text will wrap to a new line whenever it reaches the right side of the bounding box. If false, the text will always be completely on one line.
        /// </summary>
        public bool WordBreak { get; set; }

        /// <summary>
        /// Set to true to enable embedded #FFFFFF color codes. Note: clip and wordBreak are forced false if this is set.
        /// </summary>
        public bool ColorCoded { get; set; }

        /// <summary>
        /// Create a text object with a custom font
        /// </summary>
        public DxText(string text, Vector2 position, Vector2 bottomRight, Color color, Vector2 scale, Font font, HorizontalAlignEnum horizontalAlign, VerticalAlignEnum verticalAlign, float fRotation, Vector2 fRotationCenter, bool clip = false, bool wordBreak = false, bool postGUI = false, bool colorCoded = false, bool subPixelPositioning = false)
        {
            Text = text;
            Position = position;
            BottomRight = bottomRight;
            Color = color;
            Scale = scale;
            CustomFont = font;
            HorizontalAlignment = horizontalAlign;
            VerticalAlignment = verticalAlign;
            Rotation = fRotation;
            RotationOrigin = fRotationCenter;
            SubPixelPositioning = subPixelPositioning;
            PostGUI = postGUI;
            Clip = clip;
            WordBreak = wordBreak;
            ColorCoded = colorCoded;
            useCustomFont = true;
        }

        /// <summary>
        /// Create a custom font text without explicit rotation
        /// </summary>
        public DxText(string text, Vector2 position, Vector2 bottomRight, Color color, Vector2 scale, Font font, HorizontalAlignEnum horizontalAlign = HorizontalAlignEnum.LEFT, VerticalAlignEnum verticalAlign = VerticalAlignEnum.TOP, float fRotation = 0.0f) :this(text, position, bottomRight, color, scale, font, horizontalAlign, verticalAlign, fRotation, Vector2.Zero) { }

        /// <summary>
        /// Create a text object with a standard font
        /// </summary>
        public DxText(string text, Vector2 position, Vector2 bottomRight, Color color, Vector2 scale, StandardFontEnum font, HorizontalAlignEnum horizontalAlign, VerticalAlignEnum verticalAlign, float fRotation, Vector2 fRotationCenter, bool clip = false, bool wordBreak = false, bool postGUI = false, bool colorCoded = false, bool subPixelPositioning = false)
        {
            Text = text;
            Position = position;
            Color = color;
            Scale = scale;
            StandardFont = font;
            HorizontalAlignment = horizontalAlign;
            VerticalAlignment = verticalAlign;
            Rotation = fRotation;
            RotationOrigin = fRotationCenter;
            SubPixelPositioning = subPixelPositioning;
            PostGUI = postGUI;
            Clip = clip;
            WordBreak = wordBreak;
            ColorCoded = colorCoded;
            useCustomFont = false;
        }

        /// <summary>
        /// Create a standard font text without explicit rotation
        /// </summary>
        public DxText(string text, Vector2 position, Vector2 bottomRight, Color color, Vector2 scale, StandardFontEnum font, HorizontalAlignEnum horizontalAlign = HorizontalAlignEnum.LEFT, VerticalAlignEnum verticalAlign = VerticalAlignEnum.TOP, float fRotation = 0.0f) : this(text, position, bottomRight, color, scale, font, horizontalAlign, verticalAlign, fRotation, Vector2.Zero) { }

        /// <summary>
        /// Create a default text without explicit scale
        /// </summary>
        public DxText(string text, Vector2 position, Vector2 bottomRight, Color color) : this(text, position, bottomRight, color, Vector2.One, StandardFontEnum.DEFAULT) { }

        /// <summary>
        /// Create a white default text
        /// </summary>
        public DxText(string text, Vector2 position) : this(text, position, Vector2.Zero, Color.White) { }


        public bool Draw()
        {
            if (useCustomFont)
                return MTAClient.DxDrawText(Text, Position.X, Position.Y, BottomRight.X, BottomRight.Y, Color.Hex, Scale.X, Scale.Y, CustomFont.MTAFont, HorizontalAlignment.ToString().ToLower(), VerticalAlignment.ToString().ToLower(), Clip, WordBreak, PostGUI, ColorCoded, SubPixelPositioning, Rotation, RotationOrigin.X, RotationOrigin.Y);
            else
                return MTAClient.DxDrawText(Text, Position.X, Position.Y, BottomRight.X, BottomRight.Y, Color.Hex, Scale.X, Scale.Y, StandardFont.ToString().ToLower(), HorizontalAlignment.ToString().ToLower(), VerticalAlignment.ToString().ToLower(), Clip, WordBreak, PostGUI, ColorCoded, SubPixelPositioning, Rotation, RotationOrigin.X, RotationOrigin.Y);
        }

        public static float GetTextWidth(string text, float scale = 1, StandardFontEnum font = StandardFontEnum.DEFAULT, bool colorCoded = false)
        {
            return MTAClient.DxGetTextWidth(text, scale, font.ToString().ToLower(), colorCoded);
        }
    }


}
