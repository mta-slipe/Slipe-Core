using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Peds
{
    /// <summary>
    /// Manages player events
    /// </summary>
    class PlayerManager
    {
        private static PlayerManager instance;
        public static PlayerManager Instance
        {
            get
            {
                return instance ?? new PlayerManager();
            }
        }

        public PlayerManager()
        {
            instance = this;
        }

        internal void HandleJoin(Player player)
        {
            OnPlayerJoin?.Invoke(player);
        }

        public delegate void OnPlayerJoinHandler(Player player);
        public event OnPlayerJoinHandler OnPlayerJoin;
    }
}
