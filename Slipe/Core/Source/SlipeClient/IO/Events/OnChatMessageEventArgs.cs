using SlipeLua.Shared.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.IO.Events
{
    public class OnChatMessageEventArgs
    {
        /// <summary>
        /// The text of the message
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// The color of the message
        /// </summary>
        public Color Color { get; }
        
        internal OnChatMessageEventArgs(dynamic text, dynamic r, dynamic g, dynamic b)
        {
            Text = (string)text;
            Color = new Color((byte)r, (byte)g, (byte)b);
        }
    }
}
