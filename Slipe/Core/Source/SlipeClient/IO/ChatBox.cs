using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using SlipeLua.Client.IO.Events;
using SlipeLua.Shared.Elements;

namespace SlipeLua.Client.IO
{
    /// <summary>
    /// Represents the ingame chatbox
    /// </summary>
    public static class ChatBox
    {
        #region Properties

        /// <summary>
        /// Get whether the chatbox is being used
        /// </summary>
        public static bool Active
        {
            get
            {
                return MtaClient.IsChatBoxInputActive();
            }
        }

        /// <summary>
        /// Visibility of the chatbox
        /// </summary>
        public static bool Visible
        {
            get
            {
                return MtaClient.IsChatVisible();
            }
            set
            {
                MtaClient.ShowChat(value);
            }
        }

        /// <summary>
        /// Gets whether the input box is active
        /// </summary>
        public static bool InputBoxActive
        {
            get
            {
                return MtaClient.IsChatBoxInputActive();
            }
        }

        /// <summary>
        /// Get the font of the chatbox
        /// </summary>
        public static ChatBoxFont Font
        {
            get
            {
                return (ChatBoxFont) MtaClient.GetChatboxLayout("chat_font");
            }
        }

        /// <summary>
        /// Get the amount of lines in the chatbox
        /// </summary>
        public static int Lines
        {
            get
            {
                return MtaClient.GetChatboxLayout("chat_lines");
            }
        }

        /// <summary>
        /// Get the background color of the chatbox
        /// </summary>
        public static Color BackgroundColor
        {
            get
            {
                Tuple<byte, byte, byte, byte> r = MtaClient.GetChatboxLayout("chat_color");
                return new Color(r.Item1, r.Item2, r.Item3, r.Item4);
            }
        }

        /// <summary>
        /// Get the chatbox text color
        /// </summary>
        public static Color TextColor
        {
            get
            {
                Tuple<byte, byte, byte, byte> r = MtaClient.GetChatboxLayout("chat_text_color");
                return new Color(r.Item1, r.Item2, r.Item3, r.Item4);
            }
        }

        /// <summary>
        /// Get the background color of the chatbox input
        /// </summary>
        public static Color InputColor
        {
            get
            {
                Tuple<byte, byte, byte, byte> r = MtaClient.GetChatboxLayout("chat_input_color");
                return new Color(r.Item1, r.Item2, r.Item3, r.Item4);
            }
        }

        /// <summary>
        /// Get the color of the input prefix text
        /// </summary>
        public static Color InputPrefixColor
        {
            get
            {
                Tuple<byte, byte, byte, byte> r = MtaClient.GetChatboxLayout("chat_input_prefix_color");
                return new Color(r.Item1, r.Item2, r.Item3, r.Item4);
            }
        }

        /// <summary>
        /// Get the color of the text in the chatbox input
        /// </summary>
        public static Color InputTextColor
        {
            get
            {
                Tuple<byte, byte, byte, byte> r = MtaClient.GetChatboxLayout("chat_input_text_color");
                return new Color(r.Item1, r.Item2, r.Item3, r.Item4);
            }
        }

        /// <summary>
        /// Get the scale of the text in the chatbox
        /// </summary>
        public static Vector2 Scale
        {
            get
            {
                Tuple<float, float> r = MtaClient.GetChatboxLayout("chat_scale");
                return new Vector2(r.Item1, r.Item2);
            }
        }

        /// <summary>
        /// Get the offset
        /// </summary>
        public static Vector2 Offset
        {
            get
            {
                float x = MtaClient.GetChatboxLayout("chat_position_offset_x");
                float y = MtaClient.GetChatboxLayout("chat_position_offset_y");
                return new Vector2(x, y);
            }
        }

        /// <summary>
        /// Get the allignment
        /// </summary>
        public static Vector2 PositionalAlignment
        {
            get
            {
                float x = MtaClient.GetChatboxLayout("chat_position_horizontal");
                float y = MtaClient.GetChatboxLayout("chat_position_vertical");
                return new Vector2(x, y);
            }
        }

        /// <summary>
        /// Get the text alignment setting
        /// </summary>
        public static int Allignment
        {
            get
            {
                return MtaClient.GetChatboxLayout("chat_position_vertical");
            }
        }

        /// <summary>
        /// Get the scale of the background width
        /// </summary>
        public static float Width
        {
            get
            {
                return MtaClient.GetChatboxLayout("chat_width");
            }
        }

        /// <summary>
        /// Get whether text fades out over time
        /// </summary>
        public static bool TextFades
        {
            get
            {
                return MtaClient.GetChatboxLayout("chat_css_style_text");
            }
        }

        /// <summary>
        /// Get whether the background fades out over time
        /// </summary>
        public static bool BackgroundFades
        {
            get
            {
                return MtaClient.GetChatboxLayout("chat_css_style_background");
            }
        }

        /// <summary>
        /// Get how long it takes for text to start fading out
        /// </summary>
        public static float LineLife
        {
            get
            {
                return MtaClient.GetChatboxLayout("chat_line_life");
            }
        }

        /// <summary>
        /// Get how long takes for text to fade out
        /// </summary>
        public static float LineFadeOut
        {
            get
            {
                return MtaClient.GetChatboxLayout("chat_line_fade_out");
            }
        }

        /// <summary>
        /// Get whether CEGUI is used to render the chatbox
        /// </summary>
        public static bool UseCegui
        {
            get
            {
                return MtaClient.GetChatboxLayout("chat_use_cegui");
            }
        }

        /// <summary>
        /// Get the text scale
        /// </summary>
        public static float TextScale
        {
            get
            {
                return MtaClient.GetChatboxLayout("text_scale");
            }
        }

        #endregion

        /// <summary>
        /// Writes a line to the chatbox
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        /// <param name="colorCoded"></param>
        public static void WriteLine(string message, Color color, bool colorCoded = false)
        {
            MtaClient.OutputChatBox(message, color.R, color.G, color.B, colorCoded);
        }

        /// <summary>
        /// Writes a line to the chatbox
        /// </summary>
        /// <param name="message"></param>
        public static void WriteLine(string message)
        {
            WriteLine(message, Color.White);
        }

        /// <summary>
        /// Clears the chatbox
        /// </summary>
        public static void Clear()
        {
            MtaClient.ClearChatBox();
        }

        #region Events

#pragma warning disable 67

        public delegate void OnMessageHandler(Element source, OnChatMessageEventArgs eventArgs);
        public static event OnMessageHandler OnMessage;

#pragma warning restore 67

        #endregion
    }
}
