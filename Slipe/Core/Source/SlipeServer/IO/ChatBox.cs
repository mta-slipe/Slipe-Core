using SlipeLua.MtaDefinitions;
using SlipeLua.Server.IO.Events;
using SlipeLua.Server.Peds;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.IO
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
            MtaServer.OutputChatBox(message, player.MTAElement, color.R, color.G, color.B, colorCoded);
        }
        /// <summary>
        /// Writes a line to the chatbox
        /// </summary>
        /// <param name="message"></param>
        /// <param name="player"></param>
        public static void WriteLine(string message, Player player)
        {
            WriteLine(message, player, Color.White);
        }

        /// <summary>
        /// Writes a line to the chatbox
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        /// <param name="colorCoded"></param>
        public static void WriteLine(string message, Color color, bool colorCoded = false)
        {
            MtaServer.OutputChatBox(message, Element.Root.MTAElement, color.R, color.G, color.B, colorCoded);
        }

        /// <summary>
        /// Writes a line to the chatbox
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        /// <param name="colorCoded"></param>
        public static void WriteLine(string message)
        {
            WriteLine(message, Color.White);
        }

        /// <summary>
        /// Clears the chatbox for the player, if none specified for everyone.
        /// </summary>
        /// <param name="player"></param>
        public static void Clear(Player player = null)
        {
            MtaServer.ClearChatBox(player == null ? Element.Root.MTAElement : player.MTAElement);
        }

        /// <summary>
        /// Set the chatbox visibility for the player, if none specified for anyone.
        /// </summary>
        /// <param name="visible"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        public static bool SetVisible(bool visible, Player player = null)
        {
            return MtaServer.ShowChat(player == null ? Element.Root.MTAElement : player.MTAElement, visible);
        }

        #region Events
#pragma warning disable 67

        public delegate void OnMessageHandler(Element source, OnChatMessageEventArgs eventArgs);

        /// <summary>
        /// The source of the event is either the player or the resource that broadcasted the message
        /// </summary>
        public static event OnMessageHandler OnMessage;

#pragma warning restore 67
        #endregion
    }
}
