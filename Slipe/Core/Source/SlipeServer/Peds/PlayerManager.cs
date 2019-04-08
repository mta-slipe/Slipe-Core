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

            Element.OnRootEvent += HandleRootEvent;
            Element.Root.AddEventHandler("onPlayerJoin");
        }

        /// <summary>
        /// Handles player events on the root element
        /// </summary>
        public void HandleRootEvent(string eventName, MtaDefinitions.MtaElement source, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8)
        {
            switch (eventName)
            {
                case "onPlayerJoin":
                    Player player = new Player(source);
                    OnPlayerJoin?.Invoke(player);
                    break;
            }
        }

        public delegate void OnPlayerJoinHandler(Player player);
        public event OnPlayerJoinHandler OnPlayerJoin;
    }
}
