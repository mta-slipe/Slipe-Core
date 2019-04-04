using Slipe.MTADefinitions;
using Slipe.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.IO
{
    /// <summary>
    /// Represents the ingame chatbox
    /// </summary>
    public static class ChatBox
    {
        /// <summary>
        /// Visibility of the chatbox
        /// </summary>
        public static bool Visible
        {
            get
            {
                return MTAClient.IsChatVisible();
            }
            set
            {
                MTAClient.ShowChat(value);
            }
        }

        /// <summary>
        /// Gets whether the input box is active
        /// </summary>
        public static bool InputBoxActive
        {
            get
            {
                return MTAClient.IsChatBoxInputActive();
            }
        }

        /// <summary>
        /// Writes a line to the chatbox
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        /// <param name="colorCoded"></param>
        public static void WriteLine(string message, Color color, bool colorCoded = false)
        {
            MTAClient.OutputChatBox(message, color.R, color.G, color.B, colorCoded);
        }

        /// <summary>
        /// Clears the chatbox
        /// </summary>
        public static void Clear()
        {
            MTAClient.ClearChatBox();
        }
    }
}
