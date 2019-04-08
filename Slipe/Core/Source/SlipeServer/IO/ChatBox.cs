using Slipe.MTADefinitions;
using Slipe.Server.Peds;
using Slipe.Shared.Elements;
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
        /// Writes a line to the chatbox
        /// </summary>
        /// <param name="message"></param>
        /// <param name="player"></param>
        /// <param name="color"></param>
        /// <param name="colorCoded"></param>
        public static void WriteLine(string message, Player player, Color color, bool colorCoded = false)
        {
            MTAServer.OutputChatBox(message, player.MTAElement, color.R, color.G, color.B, colorCoded);
        }

        /// <summary>
        /// Writes a line to the chatbox
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        /// <param name="colorCoded"></param>
        public static void WriteLine(string message, Color color, bool colorCoded = false)
        {
            MTAServer.OutputChatBox(message, Element.Root.MTAElement, color.R, color.G, color.B, colorCoded);
        }

        /// <summary>
        /// Clears the chatbox for the player, if none specified for everyone.
        /// </summary>
        /// <param name="player"></param>
        public static void Clear(Player player = null)
        {
            MTAServer.ClearChatBox(player == null ? Element.Root.MTAElement : player.MTAElement);
        }

        /// <summary>
        /// Set the chatbox visibility for the player, if none specified for anyone.
        /// </summary>
        /// <param name="visible"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        public static bool SetVisible(bool visible, Player player = null)
        {
            return MTAServer.ShowChat(player == null ? Element.Root.MTAElement : player.MTAElement, visible);
        }
    }
}
