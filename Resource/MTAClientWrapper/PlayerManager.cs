using MTASharedWrapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTAClientWrapper
{
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

            Element.OnRootEvent += HandleRootEvent;
            Element.Root.AddEventHandler("onClientPlayerJoin");
        }

        public void HandleRootEvent(string eventName, MultiTheftAuto.Element source, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8)
        {
            switch (eventName)
            {
                case "onClientPlayerJoin":
                    Player player = new Player(source);
                    OnPlayerJoin(player);
                    break;
            }
        }

        public delegate void OnPlayerJoinHandler(Player player);
        public event OnPlayerJoinHandler OnPlayerJoin;
    }
}
