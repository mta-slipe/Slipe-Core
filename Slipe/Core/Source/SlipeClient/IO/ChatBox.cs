using Slipe.MtaDefinitions;
using Slipe.Shared.Utilities;
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
        /// Clears the chatbox
        /// </summary>
        public static void Clear()
        {
            MtaClient.ClearChatBox();
        }
    }
}
