using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds
{
    /// <summary>
    /// Class that manages events for players
    /// </summary>
    public class PlayerManager
    {
        private static PlayerManager instance;

        /// <summary>
        /// Get the player manager singleton instance
        /// </summary>
        public static PlayerManager Instance
        {
            get
            {
                return instance ?? new PlayerManager();
            }
        }

        /// <summary>
        /// Creates a playermanager instance
        /// </summary>
        public PlayerManager()
        {
            instance = this;

            Element.Root.ListenForEvent("onPlayerJoin");
        }

        internal void HandleJoin(Player player)
        {
            OnPlayerJoin?.Invoke(player);
        }


        public delegate void OnPlayerJoinHandler(Player player);
        public event OnPlayerJoinHandler OnPlayerJoin;
    }
}
