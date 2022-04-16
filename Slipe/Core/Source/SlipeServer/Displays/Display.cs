using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;
using SlipeLua.Server.Peds;
using SlipeLua.Shared.Elements;

namespace SlipeLua.Server.Displays
{
    /// <summary>
    /// Represents a text display that's visible to a selection of players
    /// </summary>
    public class Display
    {
        #region Properties

        /// <summary>
        /// Get the associated display element
        /// </summary>
        public MtaElement DisplayElement { get; }

        /// <summary>
        /// Get an array of all the observers of this display
        /// </summary>
        public Player[] Observers
        {
            get
            {
                MtaElement[] elements = MtaShared.GetArrayFromTable(MtaServer.TextDisplayGetObservers(DisplayElement), "MTAElement");
                return ElementManager.Instance.CastArray<Player>(elements);
            }
        }
        #endregion

        /// <summary>
        /// Create a new empty display
        /// </summary>
        public Display()
        {
            DisplayElement = MtaServer.TextCreateDisplay();
        }

        #region Methods

        /// <summary>
        /// Add a player who can observe this text display
        /// </summary>
        public void AddObserver(Player player)
        {
            MtaServer.TextDisplayAddObserver(DisplayElement, player.MTAElement);
        }

        /// <summary>
        /// Add multiple players as observers
        /// </summary>
        public void AddObservers(Player[] players)
        {
            foreach(Player p in players)
            {
                AddObserver(p);
            }
        }

        /// <summary>
        /// Remove an observer
        /// </summary>
        public bool RemoveObserver(Player player)
        {
            return MtaServer.TextDisplayRemoveObserver(DisplayElement, player.MTAElement);
        }

        /// <summary>
        /// Destroy this display
        /// </summary>
        public bool Destroy()
        {
            return MtaServer.TextDestroyDisplay(DisplayElement);
        }
        #endregion
    }
}
